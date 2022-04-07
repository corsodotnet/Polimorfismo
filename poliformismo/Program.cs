
using System;
namespace poliformismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cliente person = new Cliente();
            person.getData();
        }

    }
    public class Person
    {
        public string name;
        public int age { get; set; }

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
        public Conto _conto { get; set; }

        public override void getData()
        {
            name = "bruno";
            base.name = "Marco";

            Console.WriteLine(this.name); // Marco

        }
        public void AssociaConto(Conto conto)
        {
            _conto = conto;
        }
    }

    public class Conto
    {
        bool isOpened = true;
        public Cliente _cliente { get; set; }

        public Banca _banca { get; set; }
        public void associate()
        {
            _cliente.AssociaConto(this);
        }
        public Conto(Banca banca)
        {
            _banca = banca;
        }
    }

    public class Banca
    {
        public Conto[] _conto { get; set; }


        public void AddConto()
        {
            _conto[0] = new Conto(this);
        }
    }



}
