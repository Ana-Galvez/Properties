using System;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Empleado
    {
        private string nombre;
        private double salario;
        public Empleado(string nombre)
        {
            this.nombre=nombre;
        }

        public void SetSalario(double salario)
        {
            if (salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo. Se le asignará 0 como salario");
                salario = 0;
            }
            else
            {
                this.salario = salario;
            }
        }
        public double GetSalario()
        {
            return salario;
        }
    }
}
