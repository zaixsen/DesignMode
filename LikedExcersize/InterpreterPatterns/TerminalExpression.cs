using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.InterpreterPatterns
{
    public class TerminalExpression : AbstractExpression
    {
        public override void InterPret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }

    public class NonterminalExpression : AbstractExpression
    {
        public override void InterPret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}
