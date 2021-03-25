﻿using System;
using ConsoleApplication1.Properties;

namespace ConsoleApplication1
{
    public class Dog : Pet
    {
        private bool friendly;

        public Dog(bool friendly, String name)
        {
            //super name
            this.friendly = friendly;
        }

        public bool isFriendly()
        {
            return friendly;
        }

        public String talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return "Dog: " + "name=" + name + " friendly=" + friendly;
        }
    }
}