using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] opSystems = { "iOS", "Android", "Linux", "Windows" };
            var osStack = new Stack<string>(opSystems);
            foreach (var osEl in osStack)
            {
                Console.WriteLine(osEl);
            }
            Stack<string> newOsStack = new Stack<string>();
            while (osStack.Count > 0)
            {
                newOsStack.Push(osStack.Pop());
            }
            foreach (var newOsEL in newOsStack)
            {
                Console.WriteLine(newOsEL);
            }
            Console.WriteLine($"Original Stack element count:, {osStack.Count} Reversed Stack element count: ,{newOsStack.Count}");
            osStack.Clear();
            newOsStack.Clear();
            Console.WriteLine("Original and reversed stacks heas been cleared.");

            
            Stack<double> stack = new Stack<double>();
            Console.WriteLine("Enter stack lenghth:");
            int len = Convert.ToInt32(Console.ReadLine());
            double el;
            for (int i = 0; i < len; i++)
            {
                el = Convert.ToDouble(Console.ReadLine());
                stack.Push(el);
            }
            double sum = 0;
            int count = 0;
            foreach (int elem in stack)
            {
                if (elem % 2 == 0 && elem > 0)
                {
                    sum += elem;
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No even positive numbers in stack");
            }
            Console.WriteLine($"Positive even numbers sum in stack: {sum} ");
        }
    }
}
