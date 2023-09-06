using SpeechToText.Configuration;
using SpeechToText.Services;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace SpeechToText.Controllers;

public class VoiceMessageController
{
    private readonly IStorage memoryStorage; // Добавим это
    private readonly ITelegramBotClient telegramClient;
    private readonly IFileHandler audioFileHandler;

    public VoiceMessageController(ITelegramBotClient telegramBotClient, IFileHandler audioFileHandler,
        IStorage memoryStorage)
    {
        telegramClient = telegramBotClient;
        this.audioFileHandler = audioFileHandler;
        this.memoryStorage = memoryStorage; // и это
    }

    public async Task Handle(Message message, CancellationToken ct)
    {
        var fileId = message.Voice?.FileId;
        if (fileId == null)
            return;

        await audioFileHandler.Download(fileId, ct);

        string userLanguageCode =
            memoryStorage.GetSession(message.Chat.Id).LanguageCode; // Здесь получим язык из сессии пользователя
        var result = audioFileHandler.Process(userLanguageCode); // Запустим обработку
        await telegramClient.SendTextMessageAsync(message.Chat.Id, result, cancellationToken: ct);
    }
}