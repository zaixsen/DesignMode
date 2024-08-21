using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.MementoPatterns
{
    /// <summary>
    /// 备忘录模式 ： 在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。
    ///             这样以后就可将该对象恢复到原先保存的状态
    /// </summary>
    public class Memento
    {

        private string state;    //储存的数据

        public Memento(string state)
        {
            this.state = state;
        }

        public string State { get => state; }
    }
}
