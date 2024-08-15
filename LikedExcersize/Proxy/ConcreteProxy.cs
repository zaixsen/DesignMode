using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.Proxy
{
    /// <summary>
    /// 代理模式 ：为其他对象提供一种代理以控制对这个对象的访问。
    /// </summary>
    class ConcreteProxy : Subject
    {
        //保存一个引用 使其可以访问实体
        RealSubject realSubject;

        public override void Requist()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
                realSubject.Requist();
            }
        }
    }
}
