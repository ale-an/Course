using System.Collections.Concurrent;
using SpeechToText.Models;

namespace SpeechToText.Services;

public class MemoryStorage : IStorage
{
    /// <summary>
    /// Хранилище сессий
    /// </summary>
    private readonly ConcurrentDictionary<long, Session> sessions;

    public MemoryStorage()
    {
        sessions = new ConcurrentDictionary<long, Session>();
    }

    public Session GetSession(long chatId)
    {
        // Возвращаем сессию по ключу, если она существует
        if (sessions.ContainsKey(chatId))
            return sessions[chatId];

        // Создаем и возвращаем новую, если такой не было
        var newSession = new Session() {LanguageCode = "ru"};
        sessions.TryAdd(chatId, newSession);
        return newSession;
    }
}