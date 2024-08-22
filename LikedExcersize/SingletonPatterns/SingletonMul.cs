using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedExcersize.SingletonPatterns
{
    public class SingletonMul<T> where T : class, new()
    {
        private static readonly object _value;
        private static T _instace;

        public static T Instance
        {
            get
            {
                if (_instace != null)
                {
                    lock (_value)
                    {
                        if (_instace == null)
                        {
                            return new T();
                        }
                    }
                }
                return _instace;
            }
        }
    }
}
