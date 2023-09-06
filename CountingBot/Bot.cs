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

    public Bot(ITelegramBotClient telegramClient)
    {
        this.telegramClient = telegramClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        telegramClient.StartReceiving(
            HandleUpdateAsync,
            HandleErrorAsync,
            new ReceiverOptions()
            {
                AllowedUpdates = { }
            }, // Здесь выбираем, какие обновления хотим получать. В данном случае разрешены все
            cancellationToken: stoppingToken);

        Console.WriteLine("Бот запущен");
    }

    async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if (update.Type == UpdateType.Message && update.Message.Type == MessageType.Text)
            await telegramClient.SendTextMessageAsync(update.Message.Chat.Id,
                $"Длина сообщения: {update.Message.Text.Length} знаков", cancellationToken: cancellationToken);
        else
            await telegramClient.SendTextMessageAsync(update.Message.Chat.Id,
                $"Похоже, Вы отправили не текст. Отправьте текст, умоляю.", cancellationToken: cancellationToken);
    }

    Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        // Задаем сообщение об ошибке в зависимости от того, какая именно ошибка произошла
        var errorMessage = exception switch
        {
            ApiRequestException apiRequestException
                => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
            _ => exception.ToString()
        };

        // Выводим в консоль информацию об ошибке
        Console.WriteLine(errorMessage);

        // Задержка перед повторным подключением
        Console.WriteLine("Ожидаем 10 секунд перед повторным подключением.");
        Thread.Sleep(10000);

        return Task.CompletedTask;
    }
}