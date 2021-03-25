using System;

namespace ConsoleApplication1.Properties
{
    public class Teacher : Person
    {
        private int age;

        public Teacher(int age, String name)
        {
            //Super(name)
            this.Name = name;
            this.age = age;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public String talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}