using CountingBot.Models;

namespace CountingBot.Services;

public interface IStorage
{
    Session GetSession(long chatId);
}