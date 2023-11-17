using System.Linq;
using System.IO;
using usando_linQ.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        var frutas = new string[] { "Guanabana", "Fresas", "Mongo", "Mango", "Sapote", "Mango en sopa" };
        var lstMangos = frutas.Where(p=>p.StartsWith("Mango")).ToList();
        lstMangos.ForEach(p => Console.WriteLine(p));
        var lstExample = new LinqQueries();

        var numbers = new List<int> { 1,2,3,4,5,6,4,7,8,9,10 };

        var numPares = from numb in numbers where numb % 2 == 0 select numb;
        var paresNum = numbers.Where(numb => numb % 2 == 0);

        Console.Write('[');
        foreach (var item in paresNum)
        {
            Console.Write($",{item}");
        }
        Console.Write(']');

        var toWrite = lstExample.GetFruits();
        Console.WriteLine("All good");
        foreach (var item in toWrite)
        {
            Console.WriteLine(item);
        }
    }
}