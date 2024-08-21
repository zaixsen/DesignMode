using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.CompositePatterns
{
    /// <summary>
    /// 组合模式 ：将对象组合成树形结构以表示 部分-整体 的层次结构。组合模式使得用户对单个对象和组合对象的使用具有一致性
    /// </summary>
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component c in children)
            {
                c.Display(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }
    }
}
