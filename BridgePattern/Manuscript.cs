using System;

namespace BridgePattern
{
    public abstract class Manuscript
    {
        protected readonly IFormatter _formatter;

        public Manuscript(IFormatter formatter)
        {
            _formatter = formatter;
        }

        abstract public void Print();
    }

    
}
