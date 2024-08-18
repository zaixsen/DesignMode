using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.DecoratorPatterns
{
    /// <summary>
    /// 装饰模式 ： 动态的给一个对象添加一些额外的职责, 就添加功能来说，装饰模式比生成子类更为灵活
    /// </summary>
    abstract class Decorator : Component
    {
        protected Component component;
        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
