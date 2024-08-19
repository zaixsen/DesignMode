using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.BuilderPatterns
{
    /// <summary>
    /// 建造者模式 ：将一个复杂对象的构建与他的表示分离，使得同样的构建过程可以创建不同的表示
    /// </summary>
    internal abstract class Builder
    {
        public abstract void BuliderPartA();
        public abstract void BuliderPartB();
        public abstract Product GetResult();
    }
}
