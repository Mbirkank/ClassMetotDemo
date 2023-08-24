using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Name = "Birkan";
            musteri1.Surname = "Karaer";
            musteri1.TcNo = "21223123123";
            Musteri musteri2 = new Musteri();
            musteri2.Name = "Eren";
            musteri2.Surname = "Altay";
            musteri2.TcNo = "324234234";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + musteri.TcNo);
            }




            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Remove(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Remove(musteri2);
        }
    }
}
