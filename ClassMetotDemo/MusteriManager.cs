using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + "kisisi eklendi" );
        }
        public void Remove(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + "kisisi silindi");
        }
    }
}
