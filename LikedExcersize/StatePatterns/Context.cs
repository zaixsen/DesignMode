using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.StatePatterns
{
    public class Context
    {
        private State state;

        public Context(State state)
        {
            this.state = state;
        }

        public State Sta
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("当前状态：" + Sta.GetType().Name);
            }

        }

        public void Request()
        {
            state.Handle(this);
        }

    }
}
