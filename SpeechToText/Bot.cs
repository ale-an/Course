using Microsoft.Extensions.Hosting;
using SpeechToText.Controllers;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace SpeechToText;

internal class Bot : BackgroundService
{
    private readonly ITelegramBotClient telegramClient;

    // Контроллеры различных видов сообщений
    private readonly InlineKeyboardController inlineKeyboardController;
    private readonly TextMessageController textMessageController;
    private readonly VoiceMessageController voiceMessageController;
    private readonly DefaultMessageController defaultMessageController;

    public Bot(
        ITelegramBotClient telegramClient,
        InlineKeyboardController inlineKeyboardController,
        TextMessageController textMessageController, 
        VoiceMessageController voiceMessageController,
        DefaultMessageController defaultMessageController)
    {
        this.telegramClient = telegramClient;
        this.inlineKeyboardController = inlineKeyboardController;
        this.textMessageController = textMessageController;
        this.voiceMessageController = voiceMessageController;
        this.defaultMessageController = defaultMessageController;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        telegramClient.StartReceiving(
            HandleUpdateAsync,
            HandleErrorAsync,
            new ReceiverOptions()
            {
                AllowedUpdates = { }
            }, // Здесь выбираем, какие обновления хотим получать. В данном случае - разрешены все
            cancellationToken: stoppingToken);

        Console.WriteLine("Бот запущен");
    }

    async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        //  Обрабатываем нажатия на кнопки  из Telegram Bot API: https://core.telegram.org/bots/api#callbackquery
        if (update.Type == UpdateType.CallbackQuery)
        {
            await inlineKeyboardController.Handle(update.CallbackQuery, cancellationToken);
            return;
        }

        // Обрабатываем входящие сообщения из Telegram Bot API: https://core.telegram.org/bots/api#message
        if (update.Type == UpdateType.Message)
        {
            switch (update.Message!.Type)
            {
                case MessageType.Voice:
                    await voiceMessageController.Handle(update.Message, cancellationToken);
                    return;
                case MessageType.Text:
                    await textMessageController.Handle(update.Message, cancellationToken);
                    return;
                default:
                    await defaultMessageController.Handle(update.Message, cancellationToken);
                    return;
            }
        }
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
        Console.WriteLine("Ожидаем 10 секунд перед повторным подключением.");
        Thread.Sleep(10000);

        return Task.CompletedTask;
    }
}