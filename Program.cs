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
    }
}