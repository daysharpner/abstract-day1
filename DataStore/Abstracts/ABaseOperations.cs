using DataStore.Interfaces;

namespace DataStore.Abstracts
{
    // Multiple Abstract Class Inheritence NOT Allowed. 
    //public abstract class ABaseOperations: AOperations, AFormat
    //{
    //
    //}

    /// <summary>
    /// Since multiple abstract class inheritance not supported best way to have interface to inherit methods.
    /// </summary>
    public abstract class ABaseOperations : IOperations, IFormat
    {
        public abstract string GetFormatedData(string data);       

        public abstract bool Delete();
        public abstract string Read();
        public abstract bool Write(string data);
    }
}
