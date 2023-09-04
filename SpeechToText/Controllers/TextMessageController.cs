using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace SpeechToText.Controllers;

public class TextMessageController
{
    private readonly ITelegramBotClient telegramClient;

    public TextMessageController(ITelegramBotClient telegramBotClient)
    {
        telegramClient = telegramBotClient;
    }

    public async Task Handle(Message message, CancellationToken ct)
    {
        switch (message.Text)
        {
            case "/start":

                // Объект, представляющий кноки
                var buttons = new List<InlineKeyboardButton[]>();
                buttons.Add(new[]
                {
                    InlineKeyboardButton.WithCallbackData($"\u26c4 Русский", $"ru"),
                    InlineKeyboardButton.WithCallbackData($"\ud83c\udf08 English", $"en")
                });

                // передаем кнопки вместе с сообщением (параметр ReplyMarkup)
                await telegramClient.SendTextMessageAsync(message.Chat.Id,
                    $"<b> &#128081; Этот бот превращает аудио в текст.</b> {Environment.NewLine}" +
                    $"{Environment.NewLine}Теперь никто не будет раздражаться Вашим голосовым!{Environment.NewLine}",
                    cancellationToken: ct, parseMode: ParseMode.Html, replyMarkup: new InlineKeyboardMarkup(buttons));

                break;
            default:
                await telegramClient.SendTextMessageAsync(message.Chat.Id, "Отправьте аудио для превращения в текст.",
                    cancellationToken: ct);
                break;
        }
    }
}