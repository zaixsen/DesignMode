using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.MementoPatterns
{
    /// <summary>
    /// 管理者 
    /// </summary>
    public class Caretaker
    {
        private Memento memento;

        public Memento Memento { get => memento; set => memento = value; }
    }
}
