using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace ReversedLinkedList
{
    class program
    {
        static void Main(string[] args)
        {
            LinkedList<string> fantasy = new LinkedList<string>();

            LinkedListNode<string> teams = fantasy.AddFirst("Arsenal");

            fantasy.AddLast("Man united");
            fantasy.AddAfter(teams, "Totenham");
            fantasy.AddBefore(teams, "Man city");
            fantasy.AddLast("Liverpool");

            Console.WriteLine("The linked List Before Reversing: \n ");

            foreach (var item in fantasy)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("================================");

            Console.WriteLine("The linked List After Reversing: \n ");

            foreach (var item in fantasy.Reverse())
            {

                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("================================");

            Console.ReadKey();
        }

    }
}
