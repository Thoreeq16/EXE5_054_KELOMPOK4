using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node Thoriq, Hidayatullah;
        public queue()
        {
            Thoriq = null;
            Hidayatullah = null;
        }
        public void insert()
        {
            string k;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            k = Console.ReadLine();
            newnode.name = k;
            newnode.next = null;
            if (Thoriq == null)
            {
                Thoriq = newnode;
                Hidayatullah = newnode;
                return;
            }
            Thoriq.next = newnode;
            Hidayatullah = newnode;
        }
        public void delete()
        {
            if (Thoriq == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            Thoriq = Thoriq.next;
            if (Thoriq == null)
                Hidayatullah = null;
        }
        public void display()
        {
            if (Thoriq == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            Node display;
            for (display = Thoriq; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}