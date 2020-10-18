using DataStore.Interfaces;

namespace DataStore.Abstracts
{
    public abstract class AOperations: IOperations
    {
        public abstract bool Write(string data);

        public abstract string Read();

        public abstract bool Delete();
    }
}
