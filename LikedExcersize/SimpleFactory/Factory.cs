using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.SimpleFactory
{
    /// <summary>
    /// 简单工厂模式 ：根据参数的不同实例不同的对象
    /// </summary>
    class Factory
    {
        public static Operation CreateOperation(string operate)
        {
            Operation operation;
            switch (operate)
            {
                default:
                case "+":
                    operation = new AddOperation();
                    break;
                case "-":
                    operation = new SubOperation();
                    break;
                case "*":
                    operation = new MulOperation();
                    break;
                case "/":
                    operation = new DevideOperation();
                    break;
            }
            return operation;
        }

    }
}
