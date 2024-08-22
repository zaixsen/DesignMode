
namespace LikedExcersize.IteratorPatterns
{
    /// <summary>
    /// 迭代器模式 ：提供一个方法顺序访问一个聚合对象中各个元素，而又不暴露该对象的内部表示
    /// </summary>
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}
