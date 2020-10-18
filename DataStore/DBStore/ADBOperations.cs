using DataStore.Abstracts;
using DataStore.Interfaces;
using System.Configuration;

namespace DataStore.DBStore
{
    public abstract class ADBOperations : ABaseOperations
    {
        private readonly string connectionString = ConfigurationManager.AppSettings["DBConnection"];
      
        public override bool Delete()
        {
            return DBOperation.Delete(connectionString);
        } 

        public override string Read()
        {
            return DBOperation.Read(connectionString);
        }

        public override bool Write(string data)
        {
            string formatedData = GetFormatedData(data);           
            return DBOperation.Write(formatedData, connectionString);
        }
    }
}

