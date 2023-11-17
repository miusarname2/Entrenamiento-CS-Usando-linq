using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace usando_linQ.Entidades
{
    public class LinqQueries
    {
        List<Fruit> lstFruits = new List<Fruit>();

        public LinqQueries()
        {
            try
            {
                using (StreamReader reader = new StreamReader("example.json"))
                {
                    string json = reader.ReadToEnd();
                    this.lstFruits = System.Text.Json.JsonSerializer.Deserialize<List<Fruit>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true }) ?? new List<Fruit>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer/deserializar el archivo JSON: {ex.Message}");
                // Puedes agregar más manejo de errores según sea necesario
            }
        }


        public IEnumerable<Fruit> GetFruits()
        {
            return lstFruits;
        }

        public IEnumerable<Fruit> GetFruitsByPriceGte()
        {
            Console.WriteLine(from fruit in lstFruits where fruit.Price > 15 select fruit);
            return from fruit in lstFruits where fruit.Price > 15 select fruit;
        }

        public IEnumerable<Fruit> GetFruitsWithO()
        {
            Console.WriteLine(from fruit in lstFruits where fruit.Price > 15 select fruit);
            return from fruit in lstFruits where fruit.Price > 15 && (fruit.Name ?? string.Empty).Contains("a") select fruit;
        }
    }
}