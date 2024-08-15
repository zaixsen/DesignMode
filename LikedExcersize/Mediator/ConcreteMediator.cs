using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.Mediator
{
    /// <summary>
    /// 具体中介者类
    /// </summary>
    class ConcreteMediator : Mediator
    {
        //持有所有同事
        private ConcreteColleagueA colleagueA;
        private ConcreteColleagueB colleagueB;

        public ConcreteColleagueA ColleagueA { set => colleagueA = value; }
        public ConcreteColleagueB ColleagueB { set => colleagueB = value; }

        //通过中介者类将A的消息转发给B  
        /// <summary>
        /// 检测是谁发送的消息 发送给其他人
        /// </summary>
        /// <param name="message"></param>
        /// <param name="colleague"></param>
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == colleagueA)
            {
                colleagueB.Notify(message);
            }
            else
            {
                colleagueA.Notify(message);
            }
        }
    }
}
