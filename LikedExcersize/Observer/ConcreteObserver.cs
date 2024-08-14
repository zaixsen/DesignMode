using System;

namespace LikedExcersize.Observer
{
    /// <summary>
    /// 具体观察者类
    /// </summary>
    class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject concrete, string name)
        {
            subject = concrete;
            this.name = name;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("观察者" + name + "更新状态：" + observerState);
        }
    }
}
