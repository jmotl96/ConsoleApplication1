using System;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    public class Cat : Pet 
    {
        private int mousesKilled;
        
        
        public Cat(int mousesKilled, String name)
        {
            // super(name);
            this.mousesKilled = mousesKilled;
        }

        public int getMousesKilled()
        {
            return mousesKilled;
        }

        public void addMouse()
        {
            mousesKilled++;
        }

        public override string ToString()
        {
            //return base.ToString();
            return "Cat: " + "Name=" + name + " mousesKilled=" + mousesKilled;
        }
    }
}