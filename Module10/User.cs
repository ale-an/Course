namespace Module10;

public interface IUpdater<in T>
{
    void Update(T entity);
}

public class User
{
}

public class Account : User
{
}

public class UserService : IUpdater<User>
{
    public void Update(User entity)
    {
        throw new NotImplementedException();
    }
}