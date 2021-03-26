using System;

namespace ConsoleApplication1.Properties
{
    public class Teacher : Person , Talkable
    {
        private int age;

        public Teacher(int age, String name):base(name)
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

        public string getName()
        {
            return Name;
        }
    }
}