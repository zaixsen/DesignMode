using System;
using System.Collections.Generic;

namespace LikedExcersize.BuilderPatterns
{
    /// <summary>
    /// 产品类
    /// </summary>
    internal class Product
    {
        //所有部件  试想换成实际部件类
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void ShowAllParts()
        {
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
