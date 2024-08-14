
using System.Collections.Generic;

namespace LikedExcersize.Observer
{
    /// <summary>
    /// 主题抽象类
    /// </summary>
    abstract class Subject
    {
        //观察者集合
        IList<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Remove(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
