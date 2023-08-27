namespace Module10;

public class Writer : IWriter
{
    void IWriter.Write()
    {
        throw new NotImplementedException();
    }
}

public interface IWriter
{
    void Write();
}