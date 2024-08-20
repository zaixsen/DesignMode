using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.AdapterPatterns
{
    /// <summary>
    /// 目标类
    /// </summary>
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求！！！");
        }
    }
}
