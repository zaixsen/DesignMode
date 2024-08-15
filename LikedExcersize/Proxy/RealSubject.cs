using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.Proxy
{
    class RealSubject : Subject
    {
        public override void Requist()
        {
            Console.WriteLine("真实请求");
        }
    }
}
