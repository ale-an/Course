using CountingBot.Services;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CountingBot.Controllers;

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

        memoryStorage.GetSession(callbackQuery.From.Id).Choice = callbackQuery.Data;

        string choice = callbackQuery.Data switch
        {
            "text" => "Количество символов",
            "number" => "Сумма чисел",
            _ => String.Empty
        };

        await telegramClient.SendTextMessageAsync(callbackQuery.From.Id,
            $"<b>Вы выбрали — {choice}.{Environment.NewLine}</b>" +
            $"{Environment.NewLine}Никогда не поздно передумать.", cancellationToken: ct,
            parseMode: ParseMode.Html);
    }
}