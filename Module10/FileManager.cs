namespace Module10;

public class FileManager : IWriter, IReader, IMailer
{
    public void Write()
    {
        throw new NotImplementedException();
    }

    public void Read()
    {
        throw new NotImplementedException();
    }

    public void SendEmail()
    {
        throw new NotImplementedException();
    }
}
public interface IReader 
{
    void Read();
}

public interface IMailer 
{
    void SendEmail();
}