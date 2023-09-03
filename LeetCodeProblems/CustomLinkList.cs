using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class CustNode
    {
        public int value;
        public CustNode next;

        public CustNode(int v, CustNode n)
        {
            value = v;
            next = n;

        }

    }
    
    internal class CustomLinkList
    {
        private CustNode head;
        private CustNode tail;
        public void CreateCustomList()
        {
            string choice = "y";

            while (choice != "n")
            {
                Console.WriteLine("Enter Node Value:");
                int val = Convert.ToInt32(Console.ReadLine());
                CustNode n = new CustNode(val, null);

                if ((head == null) && (tail == null))
                {
                    head = n;
                    tail = n;
                }
                else
                {
                    tail.next = n;
                    tail = tail.next;
                }

                Console.WriteLine("Want to continue?:(y/n)  ");
                choice = Console.ReadLine();
            }
        }

        public void printCustomList()
        {
            CustNode runner = null;
            runner = head;

            while(runner != null)
            {
                Console.WriteLine(runner.value);
                runner = runner.next;
            }
        }

        public void InsertNodeAtBeginning()
        {
            Console.WriteLine("Enter a value to add at beginning:");
            int val = Convert.ToInt16(Console.ReadLine());
            CustNode obj = new CustNode(val, null);
            obj.next = head;
            head = obj;
        }

        public void AddAtAyPosition()
        {
            Console.WriteLine("Add value to be inserted");
            int val = Convert.ToInt16((Console.ReadLine()));
            Console.WriteLine("Enter position:");
            int pos = Convert.ToInt16((Console.ReadLine()));
            CustNode newNode = new CustNode(val, null);
            int i = 1;
            CustNode p = head;

            while(i < pos-1)
            {
                p = p.next;
                i++;
            }
            newNode.next = p.next;
            p.next = newNode;
        }
    }
}
