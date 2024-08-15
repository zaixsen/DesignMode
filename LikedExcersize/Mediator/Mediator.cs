using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.Mediator
{
    /// <summary>
    /// 中介者模式 ： 用一个中介对象来封装一系列的对象交互。中介者使各个对象不需要显示地相互引用，
    ///              从而使其耦合松散，而且可以独立地改变他们之间的交互
    /// </summary>
    abstract class Mediator  //抽象中介者类
    {
        //指定的同事对象 通过中介 将数据发送
        public abstract void Send(string message, Colleague colleague);
    }
}
