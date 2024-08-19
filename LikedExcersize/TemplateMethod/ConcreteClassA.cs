using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.TemplateMethod
{
    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("A的方法1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("A的方法2");
        }
    }

    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("B的方法1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("B的方法2");
        }
    }



}
