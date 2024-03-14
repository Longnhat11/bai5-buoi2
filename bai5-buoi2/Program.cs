using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int soRandom = random.Next(1, 100);
            int Kiemtra;
            do
            {
                Console.WriteLine("nhap so ban du doan : ");
                string n = Console.ReadLine();
                bool isNumeric = int.TryParse(n, out Kiemtra);
                while (isNumeric == false)
                {
                    Console.WriteLine("ban nhap khong phai so! xin moi nhap lai:");
                    n = Console.ReadLine();
                    isNumeric = int.TryParse(n, out Kiemtra);
                }
                if (Kiemtra > soRandom) { Console.WriteLine("so ban doan lon hon so bi mat!"); }
                else if (Kiemtra < soRandom) { Console.WriteLine("so ban du doan nho hon so bi mat!"); }
            } while (Kiemtra != soRandom);
            Console.WriteLine("chuc mung ban da doan dung so bi mat!");
            Console.ReadKey();  
        }
    }
}
