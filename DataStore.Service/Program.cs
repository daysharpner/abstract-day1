using DataStore.DBOperations;
using DataStore.FileOperations;

namespace DataStore.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomeFileOperations customeFileOperations = new CustomeFileOperations();
            customeFileOperations.Write("Welcome to Abstract Day 1 - File");

            CustomeDBOperations customeDBOperations = new CustomeDBOperations();
            customeDBOperations.Write("Welcome to Abstract Day 1 - DB");
        }
    }
}
