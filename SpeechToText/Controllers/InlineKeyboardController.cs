using SpeechToText.Services;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace SpeechToText.Controllers;

public class InlineKeyboardController
{
    private readonly IStorage memoryStorage;
    private readonly ITelegramBotClient telegramClient;

    public InlineKeyboardController(ITelegramBotClient telegramBotClient, IStorage memoryStorage)
    {
        telegramClient = telegramBotClient;
        this.memoryStorage = memoryStorage;
    }

    public async Task Handle(CallbackQuery? callbackQuery, CancellationToken ct)
    {
        if (callbackQuery?.Data == null)
            return;

        // Обновление пользовательской сессии новыми данными
        memoryStorage.GetSession(callbackQuery.From.Id).LanguageCode = callbackQuery.Data;

        // Генерим информационное сообщение
        string languageText = callbackQuery.Data switch
        {
            "ru" => "\u26c4 Русский",
            "en" => "\ud83c\udf08 Английский",
            "de" => "\ud83c\udf7b Немецкий",
            _ => String.Empty
        };

        // Отправляем в ответ уведомление о выборе
        await telegramClient.SendTextMessageAsync(callbackQuery.From.Id,
            $"<b>Язык аудио — {languageText}.{Environment.NewLine}</b>" +
            $"{Environment.NewLine}Его можно сменить в Главном меню.", cancellationToken: ct,
            parseMode: ParseMode.Html);
    }
}