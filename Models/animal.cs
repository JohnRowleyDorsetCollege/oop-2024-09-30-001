using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_09_30_001.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Cat : Animal
    {
      
    }
    public class Dog : Animal
    {

    }
}
