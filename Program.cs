using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap nam muon kiem tra: ");
        int year = int.Parse(Console.ReadLine());
        bool laNamNhuan = false;

        bool chiaHetCho4 = year % 4 == 0;
        if (chiaHetCho4)
        {
            bool chiaHetCho100 = year % 100 == 0;
            if (chiaHetCho100)
            {
                bool chiaHetCho400 = year % 400 == 0;
                if (chiaHetCho400)
                {
                    laNamNhuan = true;
                }
            }
            else
            {
                laNamNhuan = true;
            }
        }

        if (laNamNhuan)
        {
            Console.WriteLine("{0} la nam nhuan", year);
        }
        else
        {
            Console.WriteLine("{0} khong phai la nam nhuan", year);
        }
    }
}