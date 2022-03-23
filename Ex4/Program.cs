using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            float v, c, t;
            Console.WriteLine("Nhap he so v: ");
            v = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Nhap he so cos: ");
            c = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Nhap he so t: ");
            t = Convert.ToSingle(Console.ReadLine());

            if(v <= 0 || c <= 0 || t <= 0)
            {
                Console.WriteLine  ("Vui long nhap lai!");
            }
            else
            {
                double rad = Math.PI * c / 180;               
                double x = v *  Math.Cos(rad) * t;
                Console.WriteLine($"Vat di duoc {x}m tai thoi diem {t}s voi van toc dau la {v}m/s, goc nem la {c} do ");
            }
        }
    }
}
