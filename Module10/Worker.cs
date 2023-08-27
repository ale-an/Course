namespace Module10;

public class Worker : IWorker
{
    void IWorker.Build()
    {
        throw new NotImplementedException();
    }
}

public interface IWorker
{
    public void Build();
}