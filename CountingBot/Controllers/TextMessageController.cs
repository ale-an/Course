using CountingBot.Services;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace CountingBot.Controllers;

public class TextMessageController
{
    private readonly ITelegramBotClient telegramClient;
    private readonly IStorage memoryStorage;

    public TextMessageController(ITelegramBotClient telegramBotClient, IStorage memoryStorage)
    {
        telegramClient = telegramBotClient;
        this.memoryStorage = memoryStorage;
    }

    public async Task Handle(Message message, CancellationToken ct)
    {
        switch (message.Text)
        {
            case "/start":

                var buttons = new List<InlineKeyboardButton[]>();
                buttons.Add(new[]
                {
                    InlineKeyboardButton.WithCallbackData($"Количество символов", $"text"),
                    InlineKeyboardButton.WithCallbackData($"Сумма чисел", $"number"),
                });

                await telegramClient.SendTextMessageAsync(message.Chat.Id,
                    $"<b> Этот бот умеет считать символы и сумму чисел.</b> {Environment.NewLine}",
                    cancellationToken: ct, parseMode: ParseMode.Html, replyMarkup: new InlineKeyboardMarkup(buttons));

                break;
            default:
                var session = memoryStorage.GetSession(message.Chat.Id);

                switch (session.Choice)
                {
                    case "text":
                        await telegramClient.SendTextMessageAsync(message.Chat.Id,
                            $"Длина сообщения: {message.Text.Length} знака(ов).", cancellationToken: ct);
                        break;
                    case "number":
                        var arrayOfStrings = message.Text.Split(' ');
                        var sum = 0;
                        for (int i = 0; i < arrayOfStrings.Length; i++)
                        {
                            if (int.TryParse(arrayOfStrings[i], out var number))
                            {
                                sum += number;
                            }
                        }

                        await telegramClient.SendTextMessageAsync(message.Chat.Id,
                            $"Сумма чисел в сообщении — {sum}.", cancellationToken: ct);
                        break;
                    default:
                        await telegramClient.SendTextMessageAsync(message.Chat.Id, "Ошибка",
                            cancellationToken: ct);
                        break;
                }

                break;
        }
    }
}