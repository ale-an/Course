using Telegram.Bot;
using Telegram.Bot.Types;

namespace SpeechToText.Controllers;

public class VoiceMessageController
{
    private readonly ITelegramBotClient telegramClient;

    public VoiceMessageController(ITelegramBotClient telegramBotClient)
    {
        telegramClient = telegramBotClient;
    }

    public async Task Handle(Message message, CancellationToken ct)
    {
        Console.WriteLine($"Контроллер {GetType().Name} получил сообщение");
        await telegramClient.SendTextMessageAsync(message.Chat.Id, $"Получено голосовое сообщение.", cancellationToken: ct);
    }
}