using System;

namespace LikedExcersize.BridgePatterns
{
    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("B");
        }
    }
}
