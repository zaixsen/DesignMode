namespace LikedExcersize.BridgePatterns
{
    /// <summary>
    /// 桥接模式 ： 将抽象部分与它的实现部分分离，使他们都可以独立地变化
    /// </summary>
    public abstract class Implementor
    {
        public abstract void Operation();
    }
}
