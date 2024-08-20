using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.StatePatterns
{
    /// <summary>
    /// 状态模式 ： 在一个对象的内在状态改变时 允许改变其行为，这个对象看起来像是改变了其类
    /// </summary>
    public abstract class State
    {
        public abstract void Handle(Context context);

    }
}
