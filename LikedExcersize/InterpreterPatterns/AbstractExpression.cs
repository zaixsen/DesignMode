

using System;

namespace LikedExcersize.InterpreterPatterns
{

    /// <summary>
    /// 解释器模式 ：给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语言的句子
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void InterPret(Context context);
    }


}