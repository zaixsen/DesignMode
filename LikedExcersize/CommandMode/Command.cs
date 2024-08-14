

namespace LikedExcersize.CommandMode
{
    /// <summary>
    ///  命令模式 ： 将一个请求封装为一个对象， 从而使你可用不同的请求对客户进行 参数化；
    ///             对请求 排队 或 记录请求日志 ，以及支持可 撤销 的操作
    /// </summary>
    abstract class Command
    {
        protected Receiver receiver;

        //命令绑定接收者
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }
        //执行方法
        abstract public void Execute();
    }
}
