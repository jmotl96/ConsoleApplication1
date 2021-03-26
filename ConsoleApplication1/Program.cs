using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Talkable> zoo = new List<Talkable>();
            

            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Mat Green"));
            
            
            foreach (Talkable thing in zoo) {
                Console.WriteLine(thing);
            }
        }
    }
}