using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.FacadePatterns
{
    class SubSystemOne
    {
        /// <summary>
        /// 子系统接口一
        /// </summary>
        public void MethodOne()
        {
            Console.WriteLine("子系统方法一");
        }
    }

    class SubSystemTwo
    {
        /// <summary>
        /// 子系统接口二
        /// </summary>
        public void MethodTwo()
        {
            Console.WriteLine("子系统方法二");
        }
    }
    class SubSystemThree
    {
        /// <summary>
        /// 子系统接口三
        /// </summary>
        public void MethodThree()
        {
            Console.WriteLine("子系统方法三");
        }
    }

}
