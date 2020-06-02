using System;

namespace LinkedLists
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }

        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            } else if (data < next.data)
            {
                Node temp= new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }
        public void Print()
        {
            Console.Write("|"+data+"|->");
            if (next != null)
            {
                next.Print();
            }
            else
            {
                Console.Write("null\n");
            }
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);   
            }
            else
            {
                next.AddToEnd(data);
            }
        }

        public Node Get(int index)
        {
            if (next == null)
            {
                return new Node(0);
            }
            else if (index == 0)
            {
                return this;
            }
            index--;
            return next.Get(index);
        }
        
    }

    public class LinkedList
    {
        public Node headNode;

        public LinkedList()
        {
            headNode = null;
        }
        
        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            } else if (data < headNode.data)
            {
                AddToBegining(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }
        public void AddToBegining(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public Node Get(int index)
        {
            if (index == 0)
            {
                return headNode;
            }
            index--;
            return headNode.Get(index);
        }
        
        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
            else
            {
                Console.Write("null");
            }
        }
    }
}
