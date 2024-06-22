using Interfaces;

namespace savve_share
{
    public class Engine
    {
        IStorage m_Storage;
        public Engine(IStorage storage)
        {
            this.m_Storage = storage;
        }
    }
}
