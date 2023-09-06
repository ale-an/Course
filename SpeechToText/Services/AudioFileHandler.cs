using SpeechToText.Configuration;
using Telegram.Bot;
using SpeechToText.Utilities;

namespace SpeechToText.Services;

public class AudioFileHandler : IFileHandler
{
    private readonly AppSettings appSettings;
    private readonly ITelegramBotClient telegramBotClient;


    public AudioFileHandler(AppSettings appSettings, ITelegramBotClient telegramBotClient)
    {
        this.appSettings = appSettings;
        this.telegramBotClient = telegramBotClient;
    }

    public async Task Download(string fileId, CancellationToken ct)
    {
        // Генерируем полный путь файла из конфигурации
        string inputAudioFilePath = Path.Combine(appSettings.DownloadsFolder,
            $"{appSettings.AudioFileName}.{appSettings.InputAudioFormat}");

        using (FileStream destinationStream = File.Create(inputAudioFilePath))
        {
            // Загружаем информацию о файле
            var file = await telegramBotClient.GetFileAsync(fileId, ct);
            if (file.FilePath == null)
                return;

            // Скачиваем файл
            await telegramBotClient.DownloadFileAsync(file.FilePath, destinationStream, ct);
        }
    }

    public string Process(string languageCode)
    {
        string inputAudioPath = Path.Combine(appSettings.DownloadsFolder,
            $"{appSettings.AudioFileName}.{appSettings.InputAudioFormat}");
        string outputAudioPath = Path.Combine(appSettings.DownloadsFolder,
            $"{appSettings.AudioFileName}.{appSettings.OutputAudioFormat}");

        Console.WriteLine("Начинаем конвертацию...");
        AudioConverter.TryConvert(inputAudioPath, outputAudioPath);
        Console.WriteLine("Файл конвертирован");

        Console.WriteLine("Начинаем распознавание...");
        var speechText = SpeechDetector.DetectSpeech(outputAudioPath, appSettings.InputAudioBitrate, languageCode);
        Console.WriteLine("Файл распознан.");
        return speechText;
    }
}