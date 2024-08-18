using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.PrototypePatterns
{
    class ConcretePrototype : Prototype
    {

        public ConcretePrototype(string id) : base(id)
        {

        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();  //生成一个浅表副本 浅拷贝
        }
    }
}
