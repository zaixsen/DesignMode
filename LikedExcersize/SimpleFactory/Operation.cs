using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.SimpleFactory
{
    class Operation
    {
        private int numberA;
        private int numberB;

        public int NumberA { get => numberA; set => numberA = value; }
        public int NumberB { get => numberB; set => numberB = value; }
        /// <summary>
        /// 默认返回为0
        /// </summary>
        /// <returns></returns>
        public virtual int GetResult() { return 0; }
    }
}
