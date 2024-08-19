using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.BuilderPatterns
{/// <summary>
/// 指挥者类
/// </summary>
    internal class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuliderPartA();
            builder.BuliderPartB();
        }
    }
}
