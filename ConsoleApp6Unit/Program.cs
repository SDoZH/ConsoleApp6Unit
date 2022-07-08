using System;

namespace ConsoleApp6Unit
{
    class Processor : ComputerPart
    {
        public override void Work() {}
    }
    class MotherBoard : ComputerPart
    {
        public override void Work() { }
    }
    class GraphicCard : ComputerPart
    {
        public override void Work() { }
    }
    class ComputerPart
    {
        public abstract void Work();
    }


}