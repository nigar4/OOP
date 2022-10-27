using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
 public class Elephant:Animal
    {
        public Elephant(string name, int age) : base(name, age)
        {
            Biom = BiomType.Tropic;
            Eat = "trava";
            _sound = "UUUUU";
        }
    }
}
