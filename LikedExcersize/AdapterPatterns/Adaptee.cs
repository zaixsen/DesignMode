using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.AdapterPatterns
{
    /// <summary>
    /// 目标需要适配的类
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求！");
        }
    }
}
