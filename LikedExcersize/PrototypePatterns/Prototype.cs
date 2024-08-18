using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.PrototypePatterns
{
    /// <summary>
    /// 原型模式 ：用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象
    /// </summary>
    abstract class Prototype
    {
        private string id;
        public Prototype(string id)
        {
            this.id = id;
        }

        public string Id { get { return id; } }

        public abstract Prototype Clone();
    }
}
