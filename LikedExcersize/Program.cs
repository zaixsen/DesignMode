using LikedExcersize.FacadePatterns;

namespace LikedExcersize
{
    class Program
    {
        static void Main(string[] args)
        {

            Facade facade = new Facade();

            //为子系统的一组接口提供一致的界面 此模式并通过高级接口管理 使得这个接口更加容易调用
            facade.MesthGropOne();

            facade.MethodTwo();
 

           
            //链表
            //LinkedList linkedList = new LinkedList();

            //var node1 = linkedList.AddFristLinkedList(1);
            //node1 = linkedList.AddFristLinkedList(1);
            //node1 = linkedList.AddFristLinkedList(1);
            //node1 = linkedList.AddFristLinkedList(1);
            //var node2 = linkedList.AddLastLinkedList(2);

            //bool flag1 = linkedList.Contains(2);
            //bool flag2 = linkedList.Delete(1);
        }
    }

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



}

