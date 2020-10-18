using DataStore.FileStore;

namespace DataStore.FileOperations
{
    public class CustomeFileOperations : AFileOperations
    {
        public override string GetFormatedData(string data)
        {
            // add new line to the data
            return data + "\n";
        }
    }
}
