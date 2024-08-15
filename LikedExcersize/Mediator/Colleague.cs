using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.Mediator
{
    /// <summary>
    /// 抽象同事类
    /// </summary>
    abstract class Colleague
    {
        /// <summary>
        /// 每个同事持有一个中介
        /// </summary>
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
