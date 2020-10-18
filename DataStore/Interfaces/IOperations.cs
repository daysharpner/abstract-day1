namespace DataStore.Interfaces
{
    public interface IOperations
    {
        bool Write(string data);

        string Read();

        bool Delete();
    }
}
