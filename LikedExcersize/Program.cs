using LikedExcersize.FacadePatterns;
using LikedExcersize.CommandMode;
using LikedExcersize.Observer;
using LikedExcersize.Mediator;
using LikedExcersize.Proxy;
using LikedExcersize.SimpleFactory;
using LikedExcersize.StrategyPatterns;
using LikedExcersize.DecoratorPatterns;
using LikedExcersize.PrototypePatterns;
using LikedExcersize.TemplateMethod;
using LikedExcersize.BuilderPatterns;

namespace LikedExcersize
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 外观模式: 为子系统提供一个一致的界面 此模式通过一个高层接口管理 是个这个接口更加容易调用
            //外观模式
            //Facade facade = new Facade();

            ////为子系统的一组接口提供一致的界面 此模式并通过高级接口管理 使得这个接口更加容易调用
            //facade.MesthGropOne();

            //facade.MethodTwo();

            #endregion

            #region 命令模式 ：将一个命令封装为一个对象 使你用不同的请求对客户进行参数化，请求排队或记录请求日志 可支持撤销操作
            //命令模式
            //Receiver receiver = new Receiver();  //命令接收者
            //ConcreteCommand concreteCommand = new ConcreteCommand(receiver); //具体命令  命令绑定接收者
            //Invoker invoker = new Invoker();    //执行类
            //invoker.SetCommand(concreteCommand);  //设置执行具体命令类
            //invoker.Execute();      //执行
            #endregion

            #region 观察者模式 ： 是一种一对多的依赖关系 多个观察者对象监听同一个主题对象 这个主题对象改变时 所有监听此主题的都将自动更新
            //初始化主题
            //ConcreteSubject subject = new ConcreteSubject();
            ////主题添加侦听者
            //subject.Attach(new ConcreteObserver(subject, "1"));
            //subject.Attach(new ConcreteObserver(subject, "2"));
            //subject.Attach(new ConcreteObserver(subject, "3"));
            //subject.SubjectState = "所有观察者更新";
            //subject.Notify();
            #endregion

            #region 中介者模式 : 用一个中介者来封装一系列的的对象交互。中介者使各对象之间不会显示的相互引用,从而使其耦合松散,而且可以独立地改变它们之间的交互 

            ////具体中介者
            //ConcreteMediator concreteMediator = new ConcreteMediator();
            ////所有的同事
            //ConcreteColleagueA concreteColleagueA = new ConcreteColleagueA(concreteMediator);
            //ConcreteColleagueB concreteColleagueB = new ConcreteColleagueB(concreteMediator);
            ////通过中介者绑定两个同事
            //concreteMediator.ColleagueA = concreteColleagueA;
            //concreteMediator.ColleagueB = concreteColleagueB;
            ////解耦 同事 A 不会显示的调用同事 B 只会通过内部的中介者类 调用同事B的方法 并不是 A 直接调用 B 而是通过中介类 调用
            //concreteColleagueA.Send("concreteColleagueA");
            //concreteColleagueB.Send("concreteColleagueB");

            #endregion

            #region 代理模式 : 为其他类提供一个代理以控制对这个对象的访问
            //ConcreteProxy proxy = new ConcreteProxy();
            //proxy.Requist();
            #endregion

            #region 简单工厂模式 : 通过不同的参数 返回不同的实例对象

            //Operation operation = Factory.CreateOperation("/");
            //operation.NumberA = 1;
            //operation.NumberB = 1;
            //int result = operation.GetResult();
            //System.Console.WriteLine(result);

            #endregion

            #region 策略模式 : 它定义了一个算法家族 分别封装起来，让他们之间可以相互替换，此模式的算法变化，不会影响使用算法的客户

            //Context context;

            //context = new Context(new ConcreteStrategyA());
            //context.ContextInterface();

            //context = new Context(new ConcreteStrategyB());
            //context.ContextInterface();

            // context = new Context(new ConcreteStrategyC());
            //context.ContextInterface();

            #endregion

            #region 装饰模式 : 动态的给对象添加一些额外的功能 就添加来说 装饰模式比生成子类更为灵活

            //ConcreteComponent concreteComponent = new ConcreteComponent();
            //ConcreteDecoratorA concreteDecoratorA = new ConcreteDecoratorA();
            //ConcreteDecoratorB concreteDecoratorB = new ConcreteDecoratorB();

            //concreteDecoratorA.SetComponent(concreteComponent);      //给装饰A设置具体组件
            //concreteDecoratorB.SetComponent(concreteDecoratorA);     //给装饰B设置具体装饰 A
            //concreteDecoratorB.Operation(); //执行装饰B的方法会调用B已经绑定的装饰A
            ////B-->A-->Component  Operation的方法调用顺序 跟随调用父类方法一直循环调用 类似unity的组件系统 
            #endregion

            #region 原型模式 ： 通过原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象

            //ConcretePrototype concretePrototype = new ConcretePrototype("I");
            //ConcretePrototype clone = (ConcretePrototype)concretePrototype.Clone();

            //System.Console.WriteLine("clone : " + clone.Id);

            #endregion

            #region 模板方法模式 ： 定义一个操作中的算法的骨架，而将这一步骤延迟到子类中，模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤
            //AbstractClass abstractClass;
            //abstractClass = new ConcreteClassA();
            //abstractClass.TemplateMethod();
            //abstractClass = new ConcreteClassB();
            //abstractClass.TemplateMethod();
            #endregion

            #region 建造者模式 ：将一个复杂对象的构建与它的表示分离，使得同样的构建构成可以不同的表示

            //Director director = new Director();
            //Builder concreteBuilderA = new ConcreteBuilderA();
            //Builder concreteBuilderB = new ConcreteBuilderB();
            //director.Construct(concreteBuilderA);
            //Product product = concreteBuilderA.GetResult();
            //product.ShowAllParts();
            //director.Construct(concreteBuilderB);
            //product = concreteBuilderB.GetResult();
            //product.ShowAllParts();

            #endregion

            #region 链表
            //链表
            //LinkedList linkedList = new LinkedList();

            //var node1 = linkedList.AddFristLinkedList(1);
            //node1 = linkedList.AddFristLinkedList(1);
            //node1 = linkedList.AddFristLinkedList(1);
            //node1 = linkedList.AddFristLinkedList(1);
            //var node2 = linkedList.AddLastLinkedList(2);

            //bool flag1 = linkedList.Contains(2);
            //bool flag2 = linkedList.Delete(1);
            #endregion
        }

    }



    #region 链表实现类
    /// <summary>
    /// 链表节点类
    /// </summary>
    public class LikedNode
    {
        public int Value { get; set; }
        public LikedNode Next { get; set; }

        public LikedNode()
        {
            Value = 0;
            Next = null;
        }
    }

    /// <summary>
    /// 链表类
    /// </summary>
    public class LinkedList
    {
        //头节点  下一个节点
        private LikedNode frist = null;
        //最后一个节点
        private LikedNode last = null;
        //数量
        private int count;
        //链表是否为空
        private bool isEmpty;
        public LikedNode Frist
        {
            get
            {
                return frist;
            }
        }
        public LikedNode Last
        {
            get
            {
                return last;
            }
        }

        public int Count
        {
            get
            {
                return count = GetCount();
            }
        }
        public bool IsEmpty
        {
            get
            {
                return isEmpty = GetIsEmpty();
            }
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int? this[int index]
        {
            get
            {
                if (index >= Count || index > 0)
                {
                    return null;
                }
                //从头节点开始找
                LikedNode tempNode = frist;
                for (int i = 0; i < index; i++)
                {
                    tempNode = tempNode.Next;
                }
                return tempNode.Value;
            }
        }
        /// <summary>
        /// 头插法 更新头节点 添加节点 添加的是值
        /// </summary>
        /// <param name="value"></param>
        /// <returns>添加的新节点</returns>
        public LikedNode AddFristLinkedList(int value)
        {
            LikedNode tempNode = new LikedNode();
            tempNode.Value = value;

            if (frist == null)
            {
                frist = tempNode;
                last = tempNode;
            }
            else
            {
                //新节点的下一个指向当前的首节点
                tempNode.Next = frist;
                //更新首节点
                frist = tempNode;
            }
            return tempNode;
        }
        /// <summary>
        /// 尾插法 在尾部添加节点 更新索引节点
        /// </summary>
        /// <param name="likedNote"></param>
        public LikedNode AddLastLinkedList(int value)
        {
            LikedNode tempNode = new LikedNode();
            tempNode.Value = value;

            if (frist == null)
            {
                frist = tempNode;
                last = tempNode;
            }
            else
            {
                //尾节点的下一个指向新节点
                last.Next = tempNode;
                //更新尾节点
                last = tempNode;
            }
            return tempNode;
        }
        public void Clear()
        {
            frist = null;
            last = null;
        }
        /// <summary>
        /// 是否包含值
        /// </summary>
        /// <returns></returns>
        public bool Contains(int value)
        {
            //检查表是否为空
            if (frist == null) return false;
            LikedNode tempNode = frist;
            //查看是否为首节点
            if (tempNode.Value.Equals(value))
            {
                return true;
            }
            //查看所有节点
            while (true)
            {
                if (tempNode.Next != null)
                {
                    if (tempNode.Next.Value.Equals(value))
                    {
                        return true;
                    }
                    tempNode = tempNode.Next;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 删除第一个数据为value的节点
        /// </summary>
        /// <param name="value"></param>
        /// <returns>是否删除成功</returns>
        public bool Delete(int value)
        {
            //检查链表是否为空
            if (frist == null) return false;
            //检查首节点是否匹配
            LikedNode tempNode = frist;
            if (tempNode.Value.Equals(value))
            {
                frist = frist.Next;
                return true;
            }

            LikedNode tempPreviousNode = null;
            //遍历所有数据
            while (true)
            {
                if (tempNode.Next != null)
                {
                    //记录前一个节点
                    tempPreviousNode = tempNode;
                    tempNode = tempNode.Next;
                    //比较下一个节点是否匹配
                    if (tempNode.Value.Equals(value))
                    {
                        //更换节点指向  删除匹配的节点 将前一个节点的指针 指向 当前节点指向的指针
                        tempPreviousNode.Next = tempNode.Next;
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }

        }

        private int GetCount()
        {
            if (frist == null) return 0;

            int tempCount = 1;

            LikedNode tempNode = frist;

            while (true)
            {
                if (tempNode.Next != null)
                {
                    tempCount++;
                    tempNode = tempNode.Next;
                }
                else
                {
                    return tempCount;
                }
            }

        }

        private bool GetIsEmpty()
        {
            return frist == null;
        }
    }

    #endregion
}