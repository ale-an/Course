using System.Collections.Concurrent;
using CountingBot.Models;

namespace CountingBot.Services;

public class MemoryStorage : IStorage
{
    private readonly ConcurrentDictionary<long, Session> sessions;

    public MemoryStorage()
    {
        sessions = new ConcurrentDictionary<long, Session>();
    }

    public Session GetSession(long chatId)
    {
        if (sessions.ContainsKey(chatId))
            return sessions[chatId];
        
        var newSession = new Session() {Choice = "text"};
        sessions.TryAdd(chatId, newSession);
        return newSession;
    }
}