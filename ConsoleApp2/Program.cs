using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Cliente();
            person.getData();
        }

    }
    public class Person
    {
        public string name;
        public int age;

        public virtual void getData()
        {

        }

        public Person()
        {

        }
    }

    public class Cliente : Person
    {
        public string codiceCliente;
        public new string name;


        public override void getData()
        {
            name = "bruno";
            base.name = "Marco";

            Console.WriteLine(this.name); // Marco

        }
    }

}
