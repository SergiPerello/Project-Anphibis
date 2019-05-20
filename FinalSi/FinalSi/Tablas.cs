using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalSi
{
    class Tablas
    {

        public class manufacturers1
        {
            [Key]
            public int id_manufacturer { get; set; }
            public string name { get; set; }
            public string municipality { get; set; }

            public virtual ICollection<products1> products { get; set; }
            //El objecte es la forana, quan es la pare es declara el ICollection
        }

        public class products1
        {
            [Key]
            public int id_product { get; set; }
            public string title { get; set; }
            public int manufacturer { get; set; }
            public decimal price { get; set; }

            [ForeignKey("manufacturer")]
            public virtual manufacturers1 manufacturers1 { get; set; }
            public virtual ICollection<buys> buys1 { get; set; }
        }
        public class customers1
        {
            [Key]
            public int id_customers { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public string gender { get; set; }
            public DateTime birth_date { get; set; }
            public string nif { get; set; }
            public string email { get; set; }
            public string phone_number { get; set; }
            public int phone { get; set; }
            public string credit_card { get; set; }
            public virtual ICollection<buys> buys { get; set; }
        }

        public class buys
        {
            [Key]
            public int id_buys { get; set; }
            public int product { get; set; }
            public int customer { get; set; }
            public DateTime buy_date { get; set; }
            public int units { get; set; }

            [ForeignKey("customer")]
            public virtual customers1 customers1 { get; set; }
            [ForeignKey("product")]
            public virtual products1 products1 { get; set; }
        }

        public class MyContext : DbContext
        {
            public virtual DbSet<manufacturers1> manufacturer { get; set; }
            public virtual DbSet<products1> product { get; set; }
            public virtual DbSet<customers1> customer { get; set; }
            public virtual DbSet<buys> buys { get; set; }
        }

    }
}
