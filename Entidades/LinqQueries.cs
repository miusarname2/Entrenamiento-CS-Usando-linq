using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace usando_linQ.Entidades
{
    public class LinqQueries
    {
            List<Fruit> lstFruits = new List<Fruit> ();

            public LinqQueries()
        {
            using(StreamReader  reader = new StreamReader("example.json"))
            {
                string json = reader.ReadToEnd();
                this.lstFruits = System.Text.Json.JsonSerializer.Deserialize<List<Fruit>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true }) ?? new List<Fruit>();

            }
        }
    }
}