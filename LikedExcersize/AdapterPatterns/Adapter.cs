using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.AdapterPatterns
{
    /// <summary>
    /// 适配器模式 ：将一个类的接口装换成客户希望的另外一个接口。
    ///             Adapter模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作
    /// </summary>
    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
