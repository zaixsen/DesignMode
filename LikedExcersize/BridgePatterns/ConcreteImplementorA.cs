using System;

namespace LikedExcersize.BridgePatterns
{
    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("A");
        }
    }
}
