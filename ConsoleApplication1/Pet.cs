using System;

namespace ConsoleApplication1.Properties
{
    public class Pet
    {
        protected String name;

        public Pet(String name)
        {
            this.name = name;
        }

        protected Pet()
        {
            throw new NotImplementedException();
        }

        public String getName()
        {
            return name;
        }
    }
}