using CountingBot.Controllers;
using Microsoft.Extensions.Hosting;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CountingBot;

internal class Bot : BackgroundService
{
    private readonly ITelegramBotClient telegramClient;

    private readonly InlineKeyboardController inlineKeyboardController;
    private readonly TextMessageController textMessageController;
    private readonly DefaultMessageController defaultMessageController;

    public Bot(ITelegramBotClient telegramClient,
        TextMessageController textMessageController,
        DefaultMessageController defaultMessageController, 
        InlineKeyboardController inlineKeyboardController)
    {
        this.telegramClient = telegramClient;
        this.textMessageController = textMessageController;
        this.defaultMessageController = defaultMessageController;
        this.inlineKeyboardController = inlineKeyboardController;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        telegramClient.StartReceiving(
            HandleUpdateAsync,
            HandleErrorAsync,
            new ReceiverOptions()
            {
                AllowedUpdates = { }
            },
            cancellationToken: stoppingToken);

        Console.WriteLine("Бот запущен");
    }

    async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if (update.Type == UpdateType.CallbackQuery)
        {
            await inlineKeyboardController.Handle(update.CallbackQuery, cancellationToken);
            return;
        }
        
        if (update.Type == UpdateType.Message && update.Message.Type == MessageType.Text)
            await textMessageController.Handle(update.Message, cancellationToken);
        else
            await defaultMessageController.Handle(update.Message, cancellationToken);
    }

    Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        var errorMessage = exception switch
        {
            ApiRequestException apiRequestException
                => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
            _ => exception.ToString()
        };
        
        Console.WriteLine(errorMessage);
        
        Console.WriteLine("Ожидаем 10 секунд перед повторным подключением");
        Thread.Sleep(10000);

        return Task.CompletedTask;
    }
}