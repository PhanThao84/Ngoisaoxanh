using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;
class NgheSi
{
    public string Tennghesi;
    public double Sonamlamviec;
    public double Soluongtrinhdien;
    public void Nhap()
    {
        Console.Write("Nhap ten nghe si: ");
        Tennghesi=Console.ReadLine();
        Console.Write("Nhap so nam lam viec: ");
        Sonamlamviec=double.Parse(Console.ReadLine());
        Console.Write("Nhap so luong trinh dien: ");
        Soluongtrinhdien=double.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Ten nghe si: {0},So nam lam viec :{1},So luong trinh dien :{2},Luong: {3}",Tennghesi,Sonamlamviec,Soluongtrinhdien,Luong());
    }
    public virtual double Luong()
    {
        return 0;
    }
}
class Idol:NgheSi
{
    public double Soluongsukien;
    public double SoluongGameshow;
    public double KPI;
    public new void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so luong su kien: ");
        Soluongsukien=double.Parse(Console.ReadLine());
        Console.Write("So luong Gameshow: ");
        SoluongGameshow=double.Parse(Console.ReadLine());
    }
    public override double Luong()
    {
        double a = SoluongGameshow+Soluongsukien;
        if ((Soluongtrinhdien>=15)&&(a>=10))
        {
            KPI=0.3*(500*Soluongtrinhdien+200*Soluongsukien+300*SoluongGameshow);
            double b = 1000+100*Sonamlamviec+500*Soluongtrinhdien+200*Soluongsukien+300*SoluongGameshow+KPI;
            return b;
        }   
        else
        {
            KPI=0;
            double b = 1000+100*Sonamlamviec+500*Soluongtrinhdien+200*Soluongsukien+300*SoluongGameshow;
            return b;
        }
    }
    public new void Xuat()
    {
        base.Xuat();
        Console.Write(", So luong su kien: {0},So luong Gameshow: {1}",Soluongsukien,SoluongGameshow);
    }
}
class Debut:NgheSi
{
    public double SOLUONGSUKIEN;
    public double Kpi; 
    public new void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so luong su kien: ");
        SOLUONGSUKIEN=double.Parse(Console.ReadLine());
    }
    public override double Luong()
    {
        if ((Soluongtrinhdien>=20)&&(SOLUONGSUKIEN>=10))
        {
            Kpi=0.15*(300*Soluongtrinhdien+100*SOLUONGSUKIEN);
            double c = 500+50*Sonamlamviec+300*Soluongtrinhdien+100*SOLUONGSUKIEN+Kpi;
            return c;
        }
        else 
        {
            double c = 500+50*Sonamlamviec+300*Soluongtrinhdien+100*SOLUONGSUKIEN;
            return c;
        }
    }
    public new void Xuat()
    {
        Console.Write(", So luong su kien: {0}",SOLUONGSUKIEN);
    }
}
class Intern:NgheSi
{
    public double KPi;
    public override double Luong()
    {
        if (Soluongtrinhdien>=20)
        {
            KPi=0.1*200*Soluongtrinhdien;
            double d = 300+50*Sonamlamviec+200*Soluongtrinhdien+KPi;
            return d;     
        }
        else
        {
            double d = 300+50*Sonamlamviec+200*Soluongtrinhdien;
            return d;  
        }
    }
}
class NgoiSaoMoi
{
    static void Main(string [] agrs)
    {
        Idol idol1 = new Idol();
        Idol idol2 = new Idol();
        Idol idol3 = new Idol();
        // Idol idol4 = new Idol();
        // Idol idol5 = new Idol();
        // Idol idol6 = new Idol();
        // Idol idol7 = new Idol();
        Debut debut1 = new Debut();
        Debut debut2 = new Debut();
        Debut debut3 = new Debut();
        Intern intern1 = new Intern();
        Intern intern2 = new Intern();
        Intern intern3 = new Intern();
        // Intern intern4 = new Intern();
        // Intern intern5 = new Intern();
        idol1.Nhap();
        idol2.Nhap();
        idol3.Nhap();
        // idol4.Nhap();
        // idol5.Nhap();
        // idol6.Nhap();
        // idol7.Nhap();
        debut1.Nhap();
        debut2.Nhap();
        debut3.Nhap();
        intern1.Nhap();
        intern2.Nhap();
        intern3.Nhap();
        // intern4.Nhap();
        // intern5.Nhap();
        double Sumofnghesi=0;
        List<NgheSi> cacnghesi = new List<NgheSi>();
        cacnghesi.Add(idol1);
        cacnghesi.Add(idol2);
        cacnghesi.Add(idol3);
        // cacnghesi.Add(idol4);
        // cacnghesi.Add(idol5);
        // cacnghesi.Add(idol6);
        // cacnghesi.Add(idol7);
        cacnghesi.Add(debut1);
        cacnghesi.Add(debut2);
        cacnghesi.Add(debut3);
        cacnghesi.Add(intern1);
        cacnghesi.Add(intern2);
        cacnghesi.Add(intern3);
        // cacnghesi.Add(intern4);
        // cacnghesi.Add(intern5);
        NgheSi ngheSiLuongCaoNhat = cacnghesi[0];
        NgheSi ngheSiLuongThapNhat = cacnghesi[0];
        foreach (var ngheSi in cacnghesi)
        {
            if (ngheSi.Luong() > ngheSiLuongCaoNhat.Luong())
            {
                ngheSiLuongCaoNhat = ngheSi;
            }

            if (ngheSi.Luong() < ngheSiLuongThapNhat.Luong())
            {
                ngheSiLuongThapNhat = ngheSi;
            }
        }
        // foreach (var i in cacnghesi)
        // {
        //     double min = cacnghesi[1].Luong();
        //     if (cacnghesi[1].Luong()<i.Luong())
        //     {
        //         cacnghesi[1].Xuat();
        //     }
        //    else
        //    {
        //     i.Xuat();
        //    }
        // }
        Console.WriteLine("Thong tin nghe si co luong cao nhat:");
        ngheSiLuongCaoNhat.Xuat();

        Console.WriteLine("\nThong tin nghe si co luong thap nhat:");
        ngheSiLuongThapNhat.Xuat();
        for (int i = 0;i<cacnghesi.Count;i++)
        {
            Sumofnghesi+=cacnghesi[i].Luong();
        }
        Console.WriteLine("Tong luong phai chi cho tat ca nghe si trong cong ty la: {0}",Sumofnghesi);
    }
}