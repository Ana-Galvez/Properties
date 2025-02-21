using System;
using System.Runtime.InteropServices;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado ana = new Empleado("Ana");
            ana.SALARIO = 3000;
            Console.WriteLine("El sueldo del empleado es: " + ana.SALARIO);
            ana.SALARIO += -4000;
            Console.WriteLine("El sueldo con el aumento del empleado es: " + ana.SALARIO);

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

        private double EvaluarSalario(double salario)
        {
            if (salario < 0)  return salario=0;
            else return salario;
        }

        //CREACIÓN DE LA PROPERTY
        public double SALARIO
        {
            get { return this.salario; }
            set { this.salario = EvaluarSalario(value); }
        }

        //public void SetSalario(double salario)
        //{
        //    if (salario < 0)
        //    {
        //        Console.WriteLine("El salario no puede ser negativo. Se le asignará 0 como salario");
        //        salario = 0;
        //    }
        //    else
        //    {
        //        this.salario = salario;
        //    }
        //}
        //public double GetSalario()
        //{
        //    return salario;
        //}
    }
}
