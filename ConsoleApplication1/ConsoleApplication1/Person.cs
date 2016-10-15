using System;

namespace ConsoleApplication1
{
    public class Person
    {

        private int age;
        private double weight;
        private int height;
        private String firstName, lastName;

        public Person()
        {
        }

        public Person(String firstName, String lastName)
        {

        }

        public override string ToString()
        {
            return this.height + ": " + this.firstName + ": " +
                this.lastName + ": " + this.weight + ": " + this.age;
        }

        public override bool Equals(object obj)
        {
            Person temp = (Person)obj;

            if((temp.age != this.age) & (temp.lastName.Equals(this.lastName)) )
            {
                return false;
            }

            return true;
        }
        public int getSetAge
        {
            get{ return age;}

            set{ age = value;}
        }

        public int getSetHeight
        {
            get { return height; }

            set { height = value; }
        }
        public double getWeight()
        {
            return this.weight;
        }

        public void setWeight(double weight)
        {
            this.weight = weight;
        }

    }

}
