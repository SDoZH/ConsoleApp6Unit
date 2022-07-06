using System;

namespace ConsoleApp6Unit
{
    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        private int counter;
        public override int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                if (value >= 0)
                {
                    Console.WriteLine("Число долнобытьбольше нуля");
                    counter = value;
                }
            }
        }
    }
}