using SpeechToText.Models;

namespace SpeechToText.Services;

public interface IStorage
{
    /// <summary>
    /// Получение сессии пользователя по идентификатору
    /// </summary>
    Session GetSession(long chatId);
}