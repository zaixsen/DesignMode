
#region Using
using LikedExcersize.FacadePatterns;
using LikedExcersize.CommandMode;
using LikedExcersize.Observer;
using LikedExcersize.Mediator;
using LikedExcersize.Proxy;
using LikedExcersize.SimpleFactory;
//using LikedExcersize.StrategyPatterns;
using LikedExcersize.DecoratorPatterns;
using LikedExcersize.PrototypePatterns;
using LikedExcersize.TemplateMethod;
using LikedExcersize.BuilderPatterns;
using LikedExcersize.StatePatterns;
using LikedExcersize.AdapterPatterns;
using LikedExcersize.MementoPatterns;
using LikedExcersize.CompositePatterns;
using LikedExcersize.IteratorPatterns;
using System;
using LikedExcersize.BridgePatterns;
using LikedExcersize.FlyweightPatterns;
//using LikedExcersize.SingletonPatterns;

#endregion

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

            #region 状态模式 : 当一个对象的内在状态改变时允许改变其行为，这个对象看起来像是改变了其类

            //State state = new ConcreteStateA();
            //Context context = new Context(state);

            //context.Request();
            //context.Request();
            //context.Request();
            //context.Request();

            #endregion

            #region 适配器模式 ：将一个类的接口转换成客户希望另外一个接口 Adapter使得原本由于接口不兼容而不能在一起工作的那些类可以一起工作

            //Target target = new Adapter();
            //target.Request();

            #endregion

            #region 备忘录模式 ： 在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样以后就可将对象恢复到原先保存的状态
            ////发起者
            //Originator originator = new Originator();
            //originator.State = "On";
            //originator.Show();
            ////管理者  通过Memento储存发起者的备份数据 
            //Caretaker caretaker = new Caretaker();
            //caretaker.Memento = originator.CreateMemento();

            //originator.State = "Off";
            //originator.Show();

            //originator.SetMemento(caretaker.Memento);
            //originator.Show();

            #endregion

            #region 组合模式 ：将对象组合成树形结构以表示 部分-整体 的层次结构。组合模式使得用户对单个对象和组合对象的使用具有一致性

            //Composite root = new Composite("root");
            //root.Add(new Leaf("Leaf A"));
            //root.Add(new Leaf("Leaf B"));

            //Composite comp = new Composite("Composite X");
            //comp.Add(new Leaf("Leaf XA"));
            //comp.Add(new Leaf("Leaf XB"));
            //root.Add(comp);

            //Composite comp2 = new Composite("Composite XY");
            //comp2.Add(new Leaf("Leaf XYA"));
            //comp2.Add(new Leaf("Leaf XYB"));
            //comp.Add(comp2);

            //root.Add(new Leaf("Leaf C"));

            //Leaf leaf =new Leaf("Leaf D");
            //root.Add(leaf);
            //root.Remove(leaf);

            //root.Display(1);

            #endregion

            #region 迭代器模式 ：提供一种方法顺序访问一个聚合对象中各个元素，而又不暴露该对象的内部表示

            //ConcreteAggregate a = new ConcreteAggregate();

            //a[0] = "大鸟";
            //a[1] = "小菜";
            //a[2] = "222";
            //a[3] = "333";
            //a[4] = "444";

            //Iterator iterator = new ConcreteInterator(a);

            //object item = iterator.First();

            //while (!iterator.IsDone())
            //{
            //    Console.WriteLine("{0}请买票！", iterator.CurrentItem());
            //    iterator.Next();
            //}

            #endregion

            #region 单例模式 :提供一个全局访问点 并且只有一个实例

            #endregion

            #region 桥接模式 : 将抽象部分和它的实现部分分离，使它们都可以独立地变化

            //Abstraction abstraction = new Abstraction();
            //abstraction.SetImplementor(new ConcreteImplementorA());
            //abstraction.Operation();

            //abstraction.SetImplementor(new ConcreteImplementorB());
            //abstraction.Operation();

            #endregion

            #region 享元模式 ：运用共享技术有效的支持大量颗粒度的对象

            //int extrinsicstate = 22;
            //FlyweightFactory f = new FlyweightFactory();

            //Flyweight fx = f.GetFlyweight("X");
            //fx.Operation(--extrinsicstate);

            //fx = f.GetFlyweight("Y");
            //fx.Operation(--extrinsicstate);

            //fx = f.GetFlyweight("Z");
            //fx.Operation(--extrinsicstate);

            //UndharedConcreteFlyweight uf = new UndharedConcreteFlyweight();
            //uf.Operation(--extrinsicstate);

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