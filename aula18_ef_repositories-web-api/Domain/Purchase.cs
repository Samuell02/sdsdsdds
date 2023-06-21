using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula12_ef_test.Domain
{
    public class Purchase
    {
       public int Id { get; set; }
       public int cost{ get; set; }
       public int date { get; set; }
       public Person person { get; set; }
    }
}