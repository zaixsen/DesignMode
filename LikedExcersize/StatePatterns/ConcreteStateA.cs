using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.StatePatterns
{
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.Sta = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.Sta = new ConcreteStateA();
        }
    }



}
