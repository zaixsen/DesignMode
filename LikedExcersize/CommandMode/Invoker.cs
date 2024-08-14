
namespace LikedExcersize.CommandMode
{
    /// <summary>
    /// 执行类
    /// </summary>
    class Invoker
    {
        //绑定指令
        private Command command;
       
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void Execute()
        {
            command.Execute();
        }
    }
}
