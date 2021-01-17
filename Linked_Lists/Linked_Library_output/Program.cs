using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linked_Lists.Lib;
using Linked_List_Testing;

namespace Linked_Library_output
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerLinkedList list = new IntegerLinkedList();
            list.AddToEnd(4);
            list.AddToEnd(5);
            list.AddToEnd(6);
            list.AddToEnd(4);
            list.AddToEnd(6);
            list.AddToEnd(7);
            list.print();
            Console.WriteLine($"\n{ list.Count()}"); 
            Console.WriteLine($"\n{ list.sum()}");
            list.remove_duplicates();
            list.print();
            Console.WriteLine("finished count");
            
            list.print();
            Console.ReadKey();
        }
    }
}
