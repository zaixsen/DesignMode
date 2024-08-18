using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.DecoratorPatterns
{
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("对象具体的操作");
        }
    }
}
