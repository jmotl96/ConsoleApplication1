using System;

namespace ConsoleApplication1
{
    public class Person
    {
        private String name;

        public Person(String name)
        {
            this.name = name;
        }

        protected Person()
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}