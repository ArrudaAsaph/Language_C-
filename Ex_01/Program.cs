using System;

class Triangulo{
    private double base, altura;

    public Triangulo()
        {
        this.base = 0;
        this.altura = 0;
        }

    public void set_base(double v)
        {
        if (v > 0) 
            this.base = v;
        else 
            throw new ArgumentOutOfRangeException("A base do triangulo não pode ser negativa!");
        }

    public void set_altura(double v)
        {
        if (v > 0) 
            this.altura = v;
        else 
            throw new ArgumentOutOfRangeException("A Altura do triangulo não pode ser negativa!");
        }

    public double get_base()
        {
        return base;
        }

    public double get_altura()
        {
       return altura;
        }

    public double calc_area()
        {
        return base * altura / 2;
        }
}


    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Console.WriteLine("Informe o valor da base do triangulo: ");
            x.set_base(double.Parse(Console.ReadLine()));
            Console.WriteLine("Informe o valor da altura do triangulo: ");
            x.set_altura(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Base = {x.get_base()}, Altura = {x.get_altura()}");
            Console.WriteLine($"Área = {x.calc_area()}");
            Console.ReadKey();

        }
    }

