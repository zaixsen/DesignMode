using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.TemplateMethod
{
    /// <summary>
    /// 模板方法模式 ： 定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。
    ///               模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤
    /// </summary>
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
        /// <summary>
        /// 模板方法
        /// </summary>
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }

    }
}
