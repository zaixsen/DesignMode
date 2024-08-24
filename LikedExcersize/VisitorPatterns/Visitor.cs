using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.VisitorPatterns
{
    /// <summary>
    /// 访问者模式：表示一个作用于某对象结构中的个元素的操作。
    ///         它使你可以在不改变个元素的类的前提下定义作用于这些元素的新操作
    /// </summary>
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementA);
    }
}
