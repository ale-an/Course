using Telegram.Bot;
using Telegram.Bot.Types;

namespace CountingBot.Controllers;

public class DefaultMessageController
{
    private readonly ITelegramBotClient telegramClient;

    public DefaultMessageController(ITelegramBotClient telegramBotClient)
    {
        telegramClient = telegramBotClient;
    }

    public async Task Handle(Message message, CancellationToken ct)
    {
        Console.WriteLine($"Контроллер {GetType().Name} получил сообщение");
        await telegramClient.SendTextMessageAsync(message.Chat.Id, $"Получено сообщение неподдерживаемого формата",
            cancellationToken: ct);
    }
}