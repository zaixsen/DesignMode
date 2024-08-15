using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.Mediator
{

    /// <summary>
    /// 具体同事类A
    /// </summary>
    class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(Mediator mediator) : base(mediator)
        {

        }
        
        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("同事A得到信息：" + message);
        }
    }

    /// <summary>
    /// 具体同事类B
    /// </summary>
    class ConcreteColleagueB : Colleague
    {
        public ConcreteColleagueB(Mediator mediator) : base(mediator)
        {

        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("同事B得到信息：" + message);
        }
    }
}
