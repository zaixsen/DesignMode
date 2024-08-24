using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.VisitorPatterns
{
    public class ConcreteVisitorl : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine(concreteElementA.GetType().Name + "被" + GetType().Name + "访问");
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine(concreteElementB.GetType().Name + "被" + GetType().Name + "访问");
        }
    }

    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine(concreteElementA.GetType().Name + "被" + GetType().Name + "访问");
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine(concreteElementB.GetType().Name + "被" + GetType().Name + "访问");
        }
    }


}
