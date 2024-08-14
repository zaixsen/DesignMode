using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.FacadePatterns
{
    /// <summary>
    /// 外观模式 ： 为子系统中的一组接口提供一个一致的界面,
    ///            此模式定义了一个高层接口，这个接口使得这一子系统更加容易使用
    /// </summary>
    class Facade
    {
        SubSystemOne systemOne = new SubSystemOne();
        SubSystemTwo systemTwo = new SubSystemTwo();
        SubSystemThree subSystemThree = new SubSystemThree();
        public void MesthGropOne()
        {
            Console.WriteLine("子系统一接口通过本接口调用 调用方法组一");
            systemOne.MethodOne();
            systemTwo.MethodTwo();
        }

        public void MethodTwo()
        {
            Console.WriteLine("为子系统得一组接口提供相同得界面 并由高级接口调用");
            subSystemThree.MethodThree();
            systemOne.MethodOne();
        }

    }
}
