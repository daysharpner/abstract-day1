using DataStore.DBStore;

namespace DataStore.DBOperations
{
    public class CustomeDBOperations : ADBOperations
    {
        public override string GetFormatedData(string data)
        {
            // change the data to upper case
            return data.ToUpper();
        }
    }
}
