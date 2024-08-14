
namespace LikedExcersize.CommandMode
{
    /// <summary>
    /// 具体命令类
    /// 继承抽象 Command 衍生具体命令类
    /// </summary>
    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {

        }
        //执行命令
        public override void Execute()
        {
            receiver.Aciton();
        }
    }
}
