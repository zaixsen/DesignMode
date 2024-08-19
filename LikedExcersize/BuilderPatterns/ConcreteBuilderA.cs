using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.BuilderPatterns
{
    internal class ConcreteBuilderA : Builder
    {
        Product product = new Product();
        public override void BuliderPartA()
        {
            product.Add("部件 A");
        }

        public override void BuliderPartB()
        {
            product.Add("部件 B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    internal class ConcreteBuilderB : Builder
    {
        Product product = new Product();
        public override void BuliderPartA()
        {
            product.Add("部件 X");
        }

        public override void BuliderPartB()
        {
            product.Add("部件 Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
