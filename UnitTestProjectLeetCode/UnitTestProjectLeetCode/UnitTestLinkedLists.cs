using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProjectLeetCode
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTestLinkedLists
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethodAddTwoNumbers()
        {
            // Initialize
            var l1 = new ListNode(2, null);
            var l2 = new ListNode(4, l1);
            var l3 = new ListNode(3, l2);

            var d1 = new ListNode(5, null);
            var d2 = new ListNode(6, d1);
            var d3 = new ListNode(4, d2);

            var res = AddTwoNumbers(l3, d3);

            Assert.AreEqual(7, res.val);
        }

        [TestMethod]
        public void TestMethodCreateLinkedList1()
        {
            SingleLinkedList myLinkedList = new SingleLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);    // linked list becomes 1->2->3
            var val1 = myLinkedList.Get(1);   // return 2
            myLinkedList.DeleteAtIndex(1);    // now the linked list is 1->3
            var val2 = myLinkedList.Get(1);

            Assert.AreEqual(2, val1);
            Assert.AreEqual(3, val2);
        }

        /*
             ["MyLinkedList", []
            "addAtHead", 7
            "addAtHead", 2
            "addAtHead", 1
            "addAtIndex", 3,0
            "deleteAtIndex", 2
            "addAtHead", 6
            "addAtTail", 4
            "get", 4
            "addAtHead", 4
            "addAtIndex", 5, 0
            "addAtHead"] 6
         */
        [TestMethod]
        public void TestMethodCreateLinkedList2()
        {
            SingleLinkedList myLinkedList = new SingleLinkedList();
            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtIndex(3, 0);
            myLinkedList.DeleteAtIndex(2);
            myLinkedList.AddAtHead(6);
            myLinkedList.AddAtTail(4);

            var val1 = myLinkedList.Get(4);
            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtIndex(5, 0);
            myLinkedList.AddAtHead(6);

            Assert.AreEqual(4, val1);
        }

        /*
            "MyLinkedList",
            "addAtHead",7
            "addAtTail",0
            "deleteAtIndex",1
            "addAtTail",5
            "addAtIndex",1 1
            "addAtIndex", 2,6
            "deleteAtIndex",2
            "deleteAtIndex",1
            "addAtTail",7
            "addAtIndex",1 7
            "addAtTail"] 6
             */
        [TestMethod]
        public void TestMethodCreateLinkedList3()
        {
            SingleLinkedList myLinkedList = new SingleLinkedList();
            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtTail(0);
            myLinkedList.DeleteAtIndex(1);
            myLinkedList.AddAtTail(5);
            myLinkedList.AddAtIndex(1, 1);
            myLinkedList.AddAtIndex(2, 6);
            myLinkedList.DeleteAtIndex(2);
            myLinkedList.DeleteAtIndex(1);
            myLinkedList.AddAtTail(7);
            myLinkedList.AddAtIndex(1, 7);
            myLinkedList.AddAtTail(6);


            Assert.AreEqual(1, 1);

        }

        [TestMethod]
        public void TestMethodGetIntersectionNode()
        {
            // Initialize
            var l1 = new ListNode(5, null);
            var l2 = new ListNode(4, l1);
            var l3 = new ListNode(8, l2);
            var l4 = new ListNode(1, l3);
            var l5 = new ListNode(4, l4);

            var d1 = new ListNode(5, null);
            var d2 = new ListNode(6, d1);
            var d3 = new ListNode(4, d2);

            // var node = GetIntersectionNode(l5, d3);

            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void TestMethodRemoveNthFromEnd()
        {
            // Initialize
            var l1 = new ListNode(5, null);
            var l2 = new ListNode(4, l1);
            var l3 = new ListNode(8, l2);
            var l4 = new ListNode(1, l3);
            var l5 = new ListNode(4, l4);

            var node = RemoveNthFromEnd(l5, 2);

            Assert.AreEqual(4, node.val);
        }

        [TestMethod]
        public void TestMethodRemoveNthFromEnd1()
        {
            var l1 = new ListNode(5, null);
            var l5 = new ListNode(4, l1);

            var node = RemoveNthFromEnd(l5, 2);

            Assert.AreEqual(5, node.val);
        }

        [TestMethod]
        public void TestMethodRemoveNthFromEnd2()
        {
            var l1 = new ListNode(5, null);
            var l5 = new ListNode(4, l1);

            var node = RemoveNthFromEnd(l5, 1);

            Assert.AreEqual(4, node.val);
        }

        [TestMethod]
        public void TestMethodRemoveNthFromEnd3()
        {
            var l1 = new ListNode(5, null);

            var node = RemoveNthFromEnd(l1, 1);

            Assert.AreEqual(null, node);
        }

        //[1,2,3]
        [TestMethod]
        public void TestMethodRemoveNthFromEnd4()
        {
            var l1 = new ListNode(3, null);
            var l2 = new ListNode(2, l1);
            var l3 = new ListNode(1, l2);

            var node = RemoveNthFromEnd(l3, 3);

            Assert.AreEqual(2, node.val);
        }

        [TestMethod]
        public void TestMethodRemoveNthFromEnd5()
        {
            var l1 = new ListNode(3, null);
            var l2 = new ListNode(2, l1);
            var l3 = new ListNode(1, l2);

            var node = RemoveNthFromEnd(l3, 2);

            Assert.AreEqual(1, node.val);
        }

        [TestMethod]
        public void TestMethodReverseList()
        {
            var l1 = new ListNode(3, null);
            var l3 = new ListNode(1, l1);

            var node = ReverseList(l3);

            Assert.AreEqual(3, node.val);
        }

        [TestMethod]
        public void TestMethodReverseList1()
        {
            var l1 = new ListNode(3, null);
            var l2 = new ListNode(2, l1);
            var l3 = new ListNode(1, l2);

            var node = reverse(l3);

            Assert.AreEqual(2, node.next.val);
        }

        [TestMethod]
        public void TestMethodRemoveElements()
        {
            var l1 = new ListNode(3, null);
            var l2 = new ListNode(2, l1);
            var l3 = new ListNode(1, l2);

            var node = RemoveElements(l3, 2);

            Assert.AreEqual(1, node.val);
        }

        [TestMethod]
        public void TestMethodRemoveElements1()
        {
            var l1 = new ListNode(3, null);
            var l2 = new ListNode(2, l1);
            var l3 = new ListNode(2, l2);
            var l4 = new ListNode(1, l3);

            var node = RemoveElements(l4, 2);

            Assert.AreEqual(1, node.val);
        }

        [TestMethod]
        public void TestMethodRemoveElements2()
        {
            var l1 = new ListNode(2, null);
            var l2 = new ListNode(2, l1);
            var l3 = new ListNode(2, l2);
            var l4 = new ListNode(1, l3);

            var node = RemoveElements(l4, 2);

            Assert.AreEqual(1, node.val);
        }

        [TestMethod]
        public void TestMethodRemoveElements3()
        {
            var l1 = new ListNode(1, null);
            var l2 = new ListNode(2, l1);
            var l3 = new ListNode(2, l2);
            var l4 = new ListNode(2, l3);

            var node = RemoveElements(l4, 2);

            Assert.AreEqual(1, node.val);
        }

        [TestMethod]
        public void TestMethodRemoveElements4()
        {
            var l1 = new ListNode(3, null);

            var l4 = new ListNode(1, l1);

            var node = RemoveElements(l4, 2);

            Assert.AreEqual(1, node.val);
        }

        [TestMethod]
        public void TestMethodRemoveElements5()
        {
            var l1 = new ListNode(1, null);

            var l4 = new ListNode(1, l1);

            var node = RemoveElements(l4, 1);

            Assert.AreEqual(null, node);
        }

        [TestMethod]
        public void TestMethodOddEvenList()
        {
            var l1 = new ListNode(5, null);
            var l2 = new ListNode(4, l1);   //
            var l3 = new ListNode(3, l2);
            var l4 = new ListNode(2, l3);   //
            var l5 = new ListNode(1, l4);

            var node = OddEvenList(l5);

            Assert.AreEqual(3, node.next.val);
        }

        [TestMethod]
        public void TestMethodOddEvenList1()
        {
            // 2,1,3,5,6,4,7
            var l1 = new ListNode(7, null);
            var l2 = new ListNode(4, l1);
            var l3 = new ListNode(6, l2);
            var l4 = new ListNode(5, l3);
            var l5 = new ListNode(3, l4);
            var l6 = new ListNode(1, l5);
            var l7 = new ListNode(2, l6);

            var node = OddEvenList(l7);

            Assert.AreEqual(6, node.next.next.val);
        }

        [TestMethod]
        public void TestMethodIsPalindrome()
        {
            // 1,2,2,1
            var l4 = new ListNode(1, null);
            var l5 = new ListNode(2, l4);
            var l6 = new ListNode(2, l5);
            var l7 = new ListNode(1, l6);

            var node = IsPalindrome(l7);

            Assert.AreEqual(true, node);
        }

        [TestMethod]
        public void TestMethodIsPalindrome1()
        {
            // 1,2,2,3
            var l4 = new ListNode(3, null);
            var l5 = new ListNode(2, l4);
            var l6 = new ListNode(2, l5);
            var l7 = new ListNode(1, l6);

            var node = IsPalindrome(l7);

            Assert.AreEqual(false, node);
        }

        [TestMethod]
        public void TestMethodIsPalindrome2()
        {
            // 1,2,2,3
            var l4 = new ListNode(1, null);
            var l5 = new ListNode(2, l4);
            var l6 = new ListNode(3, l5);
            var l7 = new ListNode(2, l6);
            var l8 = new ListNode(1, l7);

            var node = IsPalindrome(l8);

            Assert.AreEqual(true, node);
        }


        [TestMethod]
        public void TestMethodMergeTwoLists()
        {
            // 1,2,2,3
            var l4 = new ListNode(2, null);
            var l5 = new ListNode(1, l4);

            var l6 = new ListNode(3, null);
            var l7 = new ListNode(2, l6);
            var l8 = new ListNode(1, l7);

            var node = MergeTwoLists(l5, l8);

            Assert.AreEqual(2, node.next.next.val);
        }

        [TestMethod]
        public void TestMethodMergeTwoLists1()
        {
            var l4 = new ListNode(2, null);
            var l6 = new ListNode(1, null);

            var node = MergeTwoLists(l4, l6);

            Assert.AreEqual(2, node.next.val);
        }

        [TestMethod]
        public void TestMethodFlatten()
        {
            var l2 = new Node(2, null, null, null);
            var l1 = new Node(1, null, l2, null);

            var l4 = new Node(4, null, null, null);
            var l3 = new Node(3, null, l4, null);

            var l6 = new Node(6, null, null, null);
            var l5 = new Node(5, null, l6, null);

            l6.prev = l5;
            l4.prev = l3;
            l2.prev = l1;
            l2.child = l3;
            l4.child = l5;

            var node = flatten(l1);

            Assert.AreEqual(2, node.next.val);
        }

        [TestMethod]
        public void TestMethodRotateRight()
        {
            var l5 = new ListNode(5, null);
            var l4 = new ListNode(4, l5);
            var l3 = new ListNode(3, l4);
            var l2 = new ListNode(2, l3);
            var l1 = new ListNode(1, l2);

            var node = RotateRight(l1, 2);

            Assert.AreEqual(4, node.val);
        }

        [TestMethod]
        public void TestMethodRotateRight1()
        {
            var l5 = new ListNode(5, null);
            var l4 = new ListNode(4, l5);
            var l3 = new ListNode(3, l4);
            var l2 = new ListNode(2, l3);
            var l1 = new ListNode(1, l2);

            var node = RotateRight(l1, 1);

            Assert.AreEqual(5, node.val);
        }

        [TestMethod]
        public void TestMethodRotateRight2()
        {
            var l5 = new ListNode(5, null);
            var l4 = new ListNode(4, l5);
            var l3 = new ListNode(3, l4);
            var l2 = new ListNode(2, l3);
            var l1 = new ListNode(1, l2);

            var node = RotateRight(l1, 11);

            Assert.AreEqual(5, node.val);
        }

        [TestMethod]
        public void TestMethodRotateRight3()
        {
            var l5 = new ListNode(5, null);
            var l4 = new ListNode(4, l5);
            var l3 = new ListNode(3, l4);
            var l2 = new ListNode(2, l3);
            var l1 = new ListNode(1, l2);

            var node = RotateRight(l1, 0);

            Assert.AreEqual(1, node.val);
        }

        [TestMethod]
        public void TestMethodRotateRight4()
        {
            var l5 = new ListNode(5, null);

            var node = RotateRight(l5, 50);

            Assert.AreEqual(5, node.val);
        }

        [TestMethod]
        public void TestMethodDeleteNode()
        {
            var l5 = new ListNode(5, null);
            var l4 = new ListNode(4, l5);
            var l3 = new ListNode(3, l4);
            var l2 = new ListNode(2, l3);
            var l1 = new ListNode(1, l2);

            DeleteNode(l2);

            Assert.AreEqual(3, l1.next.val);
        }

        [TestMethod]
        public void TestMethodOneIteration()
        {
            var l6 = new ListNode(3, null);
            var l5 = new ListNode(8, l6);
            var l4 = new ListNode(7, l5);
            var l3 = new ListNode(2, l4);
            var l2 = new ListNode(5, l3);
            var l1 = new ListNode(1, l2);

            allIter(l1);

            Assert.AreEqual(3, l1.next.val);
        }

        [TestMethod]
        public void TestMethodcountBinarySubstrings()
        {
            var cntSubstr = countBinarySubstrings("001100011");

            Assert.AreEqual(6, cntSubstr);
        }

        [TestMethod]
        public void TestMethodSortList()
        {
            // arrange 
            var l4 = new ListNode(3, null);
            var l3 = new ListNode(1, l4);
            var l2 = new ListNode(2, l3);
            var l1 = new ListNode(4, l2);

            // act 
            var sortedListHead = SortList(l1);

            // assert
            Assert.AreEqual(1, sortedListHead.val);
        }

        public ListNode SortList(ListNode head)
        {
            /*
             надо работать с указателями, 
             */

            return sortedMerge(head, head.next);
        }

        // Берем два списка, отсортированных по возрастанию, и объединяем их узлы
        // сделать один большой отсортированный список, который будет возвращен
        private ListNode sortedMerge(ListNode a, ListNode b)
        {
            // базовые случаи
            if (a == null)
            {
                return b;
            }
            else if (b == null)
            {
                return a;
            }

            ListNode result = null;

            // выбираем `a` или `b` и повторяем
            if (a.val <= b.val)
            {
                result = a;
                result.next = sortedMerge(a.next, b);
            }
            else
            {
                result = b;
                result.next = sortedMerge(a, b.next);
            }

            return result;
        }

        public int countBinarySubstrings(String s)
        {
            int prevRunLength = 0, curRunLength = 1, res = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1]) curRunLength++;
                else
                {
                    prevRunLength = curRunLength;
                    curRunLength = 1;
                }
                if (prevRunLength >= curRunLength) res++;
            }
            return res;
            /*int[] groups = new int[s.Length];
            int t = 0;
            groups[0] = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] != s[i])
                {
                    groups[++t] = 1;
                }
                else
                {
                    groups[t]++;
                }
            }

            int ans = 0;
            for (int i = 1; i <= t; i++)
            {
                ans += Math.Min(groups[i - 1], groups[i]);
            }
            return ans;*/
        }


        public void allIter(ListNode head)
        {
            while (head.next != null)
            {
                head = OneIteration(head);
            }

        }

        public ListNode OneIteration(ListNode head)
        {
            if (head == null) return null;

            var odd = head;
            var even = head.next;
            var evenHead = even;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;


            return evenHead;

            /*if (head == null) return null;

            var odd = head;
            var even = head.next;
            var evenHead = even;

            while (evenHead.next != null)
            {
                // разделили на 2 
                while (even != null && even.next != null)
                {
                    odd.next = even.next;
                    odd = odd.next;
                    even.next = odd.next;
                    even = even.next;
                }

                // связали 2 половины
                odd.next = evenHead;

                // переприсвоили указатели
                odd = evenHead;
                even = evenHead.next;
                evenHead = even;
            }*/



            return head;
        }

        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;

        }


        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return null;

            var curr = head;
            ListNode prev = null;
            ListNode first = null;
            var cnt = 0;

            while (curr != null)
            {
                cnt++;
                //prev = curr;
                curr = curr.next;
            }

            if (k % cnt == 0) return head;

            if (k > cnt)
                cnt = cnt - k % cnt - 1;
            else
                cnt = cnt - k - 1;

            curr = head;
            while (curr != null)
            {
                if (cnt == 0)
                {
                    first = curr.next;

                    curr.next = null;
                    curr = first;
                    cnt--;
                }
                /*else if (curr.next == null)
                {
                    curr.next = head;
                    break;
                }*/
                else
                {
                    prev = curr;
                    curr = curr.next;
                    cnt--;
                }
            }
            prev.next = head;

            return first;
        }


        /*class Solution
        {
            Dictionary<Node, Node> map = new Dictionary<Node, Node>();
            public Node copyRandomList(Node head)
            {
                if (head == null) return null;
                Node temp = new Node(head.val);
                map.Add(head, temp);
                temp.next = copyRandomList(head.next);
                if(map.TryGetValue(head.random, out var temp1))
                    temp.random = temp1;
                return temp;
            }
        }*/


        // вернёт указатель на последнего потомка  
        public Node flatten(Node head)
        {
            var firstPointer = head;

            Stack<Node> stk = new Stack<Node>();

            while (head != null)
            {
                if (head.child != null)
                {
                    // if exist nodes after head push it in stack
                    if (head.next != null) stk.Push(head.next);

                    head.next = head.child;
                    head.next.prev = head;

                    head.child = null;
                }
                else if (head.next == null && stk.Count() != 0)
                {
                    head.next = stk.Pop();
                    head.next.prev = head;
                }

                // в остальных случаях
                head = head.next;
            }

            return firstPointer;
            /*Node p = head;

            // Traverse the list
            while (p != null)
            {
                if (p.child != null)
                {
                    Node right = p.next;

                    //Process child
                    p.next = flatten(p.child);
                    p.next.prev = p;
                    p.child = null;

                    while (p.next != null)
                        p = p.next;

                    //Reconnect next 
                    if (right != null)
                    {
                        p.next = right;
                        p.next.prev = p;
                    }
                }
                p = p.next;
            }
            return head;*/
        }

        public class Node
        {
            public int val;
            public Node prev;
            public Node next;
            public Node child;

            public Node(int val = 0, Node prev = null, Node next = null, Node child = null)
            {
                this.val = val;
                this.prev = prev;
                this.next = next;
                this.child = child;
            }
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null) return null;
            if (list1 != null && list2 == null) return list1;
            if (list1 == null && list2 != null) return list2;
            // left pointer
            var left = list1;
            // left pointer
            var right = list2;
            ListNode res = new ListNode(0);

            var head = res;

            while (left != null || right != null)
            {
                if (left == null || (right != null && left.val > right.val))
                {
                    res.next = right;
                    right = right.next;
                }
                else
                {
                    res.next = left;
                    left = left.next;
                }
                res = res.next;
            }

            return head.next;
        }


        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return false;
            if (head.next == null) return true;

            // Check element count in list
            var count = 0;
            var curr = head;
            while (curr != null)
            {
                curr = curr.next;
                count++;
            }

            // Reverse list from the middle
            var back = head;
            curr = head;
            var cnt1 = 0;
            var addVal = count % 2 == 0 ? 0 : 1;
            while (curr != null)
            {
                if (cnt1 == count / 2 + addVal)
                {
                    back = reverse(curr);
                    break;
                }
                curr = curr.next;
                cnt1++;

            }

            // Check palindrom
            while (back != null)
            {
                if (head.val != back.val) return false;

                back = back.next;
                head = head.next;
            }

            return true;
        }

        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;

            var odd = head;
            var even = head.next;
            var evenHead = even;

            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }

            odd.next = evenHead;

            return head;

            /*
             // если на вход пустая нода но вернём нулл
            if (head == null) return null;
            if (head.next == null) return head;

            ListNode odd =  head;
            ListNode even =  head.next;
            ListNode evenHead = head.next;

            var curr = head.next.next;
            var isOdd = true;
            while(curr!= null)
            {
                if (isOdd)
                {
                    odd.next = curr;
                    odd = curr;
                }
                else
                {
                    even.next = curr;
                    even = curr;
                }

                curr = curr.next;
                isOdd = !isOdd;
            }

            // если последний чётный
            if (odd.next != null && odd.next.next == null)
            {
                odd.next = evenHead;
            }

            // если последний нечётный
            if (even.next != null && even.next.next == null)
            {
                odd.next = evenHead;
                even.next = null;
            }


            return head;
             */
        }

        public ListNode RemoveElements(ListNode head, int val)
        {
            // если на вход пустая нода но вернём нулл
            if (head == null) return null;

            // пока 1-e число
            while (head != null && head.val == val)
            {
                head = head.next;
            }

            var curr = head;

            while (curr != null)
            {
                /* здесь должно быть условие при котором элемент удаляется и как он удаляется*/
                while (curr.next != null && curr.next.val == val)
                {
                    curr.next = curr.next.next;
                }
                curr = curr.next;
            }


            return head;
        }


        // Recursion
        public ListNode ReverseList(ListNode head)
        {

            if (head == null) return null;
            if (head.next == null) return head;

            ListNode prev = null;
            ListNode next;

            var curr = head;

            while (curr != null)
            {
                next = curr.next;

                curr.next = prev;

                prev = curr;
                curr = next;
            }

            return prev;
            /*if (head == null) return null;

            ListNode next;
            ListNode prev = null;

            var curr = head;

            while(curr!=null)
            {
                next = curr.next;
                curr.next = prev;

                // for next iteration
                prev = curr;
                curr = next;
            }

            return prev;*/
        }

        public ListNode reverse(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            ListNode last = reverse(head.next);
            head.next.next = head;
            head.next = null;
            return last;
        }


        /// <summary>
        /// Удаление n-th узла с конца списка
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null)
                return null;

            // последний элемент
            var l1 = head;
            // n-1 элемент
            var l2 = head;

            // текущий индекс
            var curIndx = 0;
            while (l1 != null || l1.next != null)
            {
                if (curIndx > n - 1)
                    l2 = l2.next;

                l1 = l1.next;

                curIndx++;

                // последняя итерация
                if (l1.next == null)
                {


                    break;
                }
            }

            if (l2 == head && n > 1 && n != curIndx)
            {
                var tmp = l2.next;
                l2.next = null;
                head = tmp;
            }
            else if (l2.next.next == null)
            {
                l2.next = null;
            }
            else
            {
                var tmp = l2.next.next;
                l2.next = null;
                l2.next = tmp;
            }

            return head;
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var l1 = headA;
            var l2 = headB;
            while (l1 != l2)
            {
                l1 = l1.next;
                l2 = l2.next;

            }

            return l1;
        }

        // Нода связанного списка
        /*public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }*/

        // Реализация связанного списка
        public class SingleLinkedList
        {
            private ListNode _head;
            private ListNode _tail;

            public int Count
            {
                get;
                private set;
            }

            public SingleLinkedList()
            {
                _head = null;
                _tail = null;
            }

            // Получение значения ноды связанного списка по индексу 
            public int Get(int index)
            {
                var curIndx = 0;
                var current = _head;

                while (curIndx != Count)
                {
                    if (index == curIndx)
                    {
                        return current.val;
                    }

                    current = current.next;
                    curIndx++;
                }
                return -1;
            }

            // Добавление в начало списка
            public void AddAtHead(int val)
            {
                var node = new ListNode(val);

                if (_head != null)
                {
                    node.next = _head;
                    _head = node;
                }
                else
                {
                    _head = node;
                    _tail = node;
                }
                Count++;
            }

            // Добавление в конец списка
            public void AddAtTail(int val)
            {
                var node = new ListNode(val);
                if (_tail != null)
                {
                    _tail.next = node;
                    _tail = node;
                }
                else
                {
                    _head = node;
                    _tail = node;
                }
                Count++;
            }

            // Добавление в ноду по значению index следующей ноды со значением val
            public void AddAtIndex(int index, int val)
            {
                if (index == Count)
                {
                    AddAtTail(val);
                    return;
                }


                if (index < Count)
                {
                    var curIndx = 0;
                    ListNode current = _head;
                    var node = new ListNode(val);

                    if (index == curIndx)
                    {
                        AddAtHead(val);
                    }
                    else
                    {
                        var old = current;
                        current = current.next;
                        curIndx++;
                        while (current != null)
                        {
                            if (curIndx == index)
                            {
                                old.next = node;
                                node.next = current;

                                Count++;
                                return;
                            }

                            old = current;
                            current = current.next;
                            curIndx++;
                        }
                    }
                }
            }

            // Удалить ноду по индексу
            public void DeleteAtIndex(int index)
            {
                var curIndx = 0;
                var current = _head;

                if (index == curIndx)
                {
                    if (_head.next != null)
                    {
                        _head = _head.next;
                        Count--;
                    }
                    else
                    {
                        _head = null;
                        _tail = null;
                        Count = 0;
                    }
                }
                else
                {
                    var old = current;
                    current = current.next;
                    curIndx++;
                    while (curIndx != Count)
                    {
                        if (index == curIndx)
                        {
                            if (old.next == _tail) _tail = old;
                            old.next = current.next;
                            Count--;
                            return;
                        }

                        old = current;
                        current = current.next;
                        curIndx++;
                    }
                }
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            /*ListNode dummyHead = new ListNode();
            var p = l1;
            var q = l2;
            var curr = dummyHead;
            var carry = 0;
            while (p != null || q != null)
            {
                var x = (p != null) ? p.val : 0;
                var y = (q != null) ? q.val : 0;

                var sum = carry + x + y;
                carry = sum / 10;

                curr.next = new ListNode(sum % 10);
                // создаём вложенную ноду 
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            // есть лишние остаток по разрядам от суммы 
            // то добавляем слева, в конец связанного списка
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;*/

            var res = new ListNode();

            var l = l1;
            var p = l2;
            var curr = res;
            var sum = 0;
            while (l != null || p != null)
            {
                var x = l != null ? l.val : 0;
                var y = p != null ? p.val : 0;
                sum = sum + x + y;

                curr.next = new ListNode(sum % 10);
                curr = curr.next;

                sum = sum > 9 ? 1 : 0;

                if (l != null) l = l.next;
                if (p != null) p = p.next;

            }

            if (sum != 0)
                curr.next = new ListNode(sum);

            return res.next;
        }




        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode prev;

            public ListNode(int val = 0, ListNode next = null, ListNode prev = null)
            {
                this.val = val;
                this.prev = prev;
                this.next = next;
            }
        }

        public class DoubleLinkedList
        {
            private ListNode _head;
            private ListNode _tail;

            public int Count
            {
                get;
                private set;
            }

            public DoubleLinkedList()
            {
                _head = null;
                _tail = null;
            }

            // Получение значения ноды связанного списка по индексу 
            public int Get(int index)
            {
                var curIndx = 0;
                var current = _head;

                while (curIndx != Count)
                {
                    if (index == curIndx)
                    {
                        return current.val;
                    }

                    current = current.next;
                    curIndx++;
                }
                return -1;
            }

            // Добавление в начало списка
            public void AddAtHead(int val)
            {
                var node = new ListNode(val);

                if (_head != null)
                {
                    node.next = _head;
                    _head.prev = node;

                    _head = node;
                }
                else
                {
                    _head = node;
                    _tail = node;
                }
                Count++;
            }

            // Добавление в конец списка
            public void AddAtTail(int val)
            {
                var node = new ListNode(val);
                if (_tail != null)
                {
                    _tail.next = node;
                    node.prev = _tail;

                    _tail = node;
                }
                else
                {
                    _head = node;
                    _tail = node;
                }
                Count++;
            }

            // Добавление в ноду по значению index следующей ноды со значением val
            public void AddAtIndex(int index, int val)
            {
                if (index == Count)
                {
                    AddAtTail(val);
                    return;
                }


                if (index < Count)
                {
                    var curIndx = 0;
                    ListNode current = _head;
                    var node = new ListNode(val);

                    if (index == curIndx)
                    {
                        AddAtHead(val);
                    }
                    else
                    {
                        var old = current;
                        current = current.next;
                        curIndx++;
                        while (current != null)
                        {
                            // found index
                            if (curIndx == index)
                            {
                                old.next = node;
                                node.prev = old;

                                node.next = current;
                                current.prev = node;

                                Count++;
                                return;
                            }

                            old = current;
                            current = current.next;
                            curIndx++;
                        }
                    }
                }
            }

            // Удалить ноду по индексу
            public void DeleteAtIndex(int index)
            {
                var curIndx = 0;
                var current = _head;

                if (index == curIndx)
                {
                    if (_head.next != null)
                    {
                        _head = _head.next;
                        _head.prev = null;
                        Count--;
                    }
                    else
                    {
                        _head = null;
                        _tail = null;
                        Count = 0;
                    }
                }
                else
                {
                    var old = current;

                    current = current.next;

                    curIndx++;
                    while (curIndx != Count)
                    {
                        // found index
                        if (index == curIndx)
                        {

                            if (old.next == _tail) { _tail = old; _tail.next = null; }

                            old.next = current.next;
                            current.next.prev = old;
                            Count--;
                            return;
                        }

                        old = current;
                        current = current.next;
                        curIndx++;
                    }
                }
            }
        }
        /*
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode pre;
            public ListNode(int value)
            {
                this.val = value;
            }
        }

        public class MyLinkedList
        {
            ListNode head;
            ListNode tail;
            int size;

            /** Initialize LinkedList here. */
        /*public MyLinkedList()
        {
            head = new ListNode(0);
            tail = new ListNode(0);
            head.next = tail;
            tail.pre = head;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        /*public int get(int index)
        {
            if (index < 0 || index >= size) return -1;
            ListNode curr = head;
            for (int i = 0; i <= index; i++)
            {
                curr = curr.next;
            }
            return curr.val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        /* public void addAtHead(int val)
         {
             addAtIndex(0, val);
         }

         /** Append a node of value val to the last element of the linked list. */
        /*public void addAtTail(int val)
        {
            addAtIndex(size, val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        /*public void addAtIndex(int index, int val)
        {
            if (index < 0 || index > size) return;
            ListNode curr = head;
            for (int i = 0; i < index; i++)
            {
                curr = curr.next;
            }
            ListNode newNode = new ListNode(val);
            newNode.next = curr.next;
            newNode.next.pre = newNode;
            curr.next = newNode;
            newNode.pre = curr;
            size++;
        }


        /** Delete the index-th node in the linked list, if the index is valid. */
        /*public void deleteAtIndex(int index)
        {
            if (index < 0 || index >= size) return;
            ListNode curr = head;
            for (int i = 0; i <= index; i++)
            {
                curr = curr.next;
            }
            // delete curr;
            curr.next.pre = curr.pre;
            curr.pre.next = curr.next;
            size--;
        }
    }*/
    }
}
