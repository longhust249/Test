using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Ex3
    {
        static void Main(string[] args)
        {
            chuoiphanso c = new chuoiphanso();
            c.Nhap();          
            c.Xuat();
            phanso tong = c.tinhtong();
            Console.Write("Tong  la : ");
            tong.xuat();
            Console.ReadLine();
        }
    }
    class phanso
    {
        private float tu, mau;
        public float TuSo
        {
            get { return tu; }
            set { tu = value; }
        }
        public float MauSo
        {
            get { return mau; }
            set
            {
                if (value != 0)
                    mau = value;
            }
        }
        public void nhap()
        {
            Console.Write("+ Nhap tu so: ");
            tu = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("+ Nhap mau so: ");
                mau = Convert.ToInt32(Console.ReadLine());

            } while (mau == 0);

        }
        public static phanso operator +(phanso phanSo1, phanso phanSo2) // toán tử cộng 2 phân  số
        {
            phanso phansoKQ = new phanso();
            phansoKQ.TuSo = phanSo1.TuSo * phanSo2.MauSo + phanSo2.TuSo * phanSo1.MauSo;
            phansoKQ.MauSo = phanSo1.MauSo * phanSo2.MauSo;
            return phansoKQ;
        }
        

        
        public float UCLN(float a, float b) // tìm uoc chung của tử số và mẫu số
        {
            a = Math.Abs(tu);
            b = Math.Abs(mau);
            while (a != b && b != 0 && a != 0)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        public phanso RutGonPhanSo() // rút gọn tử và mẫu
        {
            phanso rutgon = new phanso();
            float uoc = UCLN(tu, mau);
            if (uoc != 0)
            {
                rutgon.tu = tu / uoc;
                rutgon.mau = mau / uoc;
            }
            else
            {
                rutgon.tu = tu;
                rutgon.mau = mau;
            }
            return rutgon;
        }
        public void xuat()
        {
            Console.Write(" {0}/{1} ", tu, mau);
        }
    }
    class chuoiphanso
    {
        phanso[] ps;
        int n;
        public void Nhap()
        {

            Console.Write("Nhap so luong phan so :");
            n = Convert.ToInt32(Console.ReadLine());
            ps = new phanso[n];
            for (int i = 0; i < n; i++)
            {
                ps[i] = new phanso();
                Console.WriteLine("Phan so thu {0}", i + 1);
                ps[i].nhap();
                ps[i] = ps[i].RutGonPhanSo();
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < n; i++)
            {
                ps[i].xuat();
                Console.Write(" , ");
            }
        }
        public void hoanvi(phanso a, phanso b)
        {
            phanso temp;
            temp = a;
            a = b;
            b = temp;
        }
        public phanso tinhtong()
        {
            phanso tong = ps[0];
            for (int i = 1; i < n; i++)
            {
                tong = tong + ps[i];
            }
            return tong;
        }                
    }
}
