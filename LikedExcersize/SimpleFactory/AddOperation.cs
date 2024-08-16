using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.SimpleFactory
{
    class AddOperation : Operation
    {
        public override int GetResult()
        {
            return NumberA + NumberB;
        }

    }

    class SubOperation : Operation
    {
        public override int GetResult()
        {
            return NumberA - NumberB;
        }

    }
    class MulOperation : Operation
    {
        public override int GetResult()
        {
            return NumberA * NumberB;
        }
    }
    class DevideOperation : Operation
    {
        public override int GetResult()
        {
            if (NumberB != 0)
            {
                return NumberA / NumberB;
            }
            return 0;
        }
    }

}
