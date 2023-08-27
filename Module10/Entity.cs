namespace Module10;

public class Entity : ICreatable, IDeletable, IUpdatable
{
    public void Create()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}

public interface ICreatable
{
    void Create();
}

public interface IDeletable
{
    void Delete();
}

public interface IUpdatable
{
    void Update();
}