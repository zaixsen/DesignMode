using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.MementoPatterns
{
    /// <summary>
    /// 发起者 进行备份的类
    /// </summary>
    public class Originator
    {
        private string state;   //可以是多个数据

        public string State { get => state; set => state = value; }

        /// <summary>
        /// 保存备份
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        /// <summary>
        /// 恢复备份
        /// </summary>
        /// <param name="memento"></param>
        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }

        public void Show()
        {
            Console.WriteLine(state);
        }
    }
}
