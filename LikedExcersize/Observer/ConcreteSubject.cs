

namespace LikedExcersize.Observer
{
    /// <summary>
    /// 具体主题类 就是这次发送的主题 使得观察者该做怎么样的判断
    /// </summary>
    class ConcreteSubject : Subject
    {
        private string subjectState;

        public string SubjectState { 
            get { return subjectState; } 
            set { subjectState = value; } 
        }
    }
}
