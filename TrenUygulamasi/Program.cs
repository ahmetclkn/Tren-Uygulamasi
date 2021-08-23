using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int vagon1 = 40;
            int vagon2 = 70;
            int vagon3 = 68;
            int vagon4 = 60;

            Console.WriteLine("Vagon 1 Kişi Sayısı: " + vagon1 + "\n" + "Vagon 2 Kişi Sayısı: " + vagon2 + "\n" + "Vagon 3 Kişi Sayısı: " + vagon3 + "\n" + "Vagon 4 Kişi Sayısı: " + vagon4);
            Console.WriteLine("Vagon Numaranızı Seçiniz: ");
            int vagonnumarasi = Convert.ToInt32(Console.ReadLine());
           
            
                switch (vagonnumarasi)
                {
                    case 1:
                    int kapasite = 40;
                    Console.WriteLine("Rezervasyon Yapmak İstediğiniz Kişi Sayısını Giriniz: ");
                    int yolcusayisi = Convert.ToInt32(Console.ReadLine());
                    int toplamyolcu = (kapasite + yolcusayisi);

                    if (toplamyolcu > 70)
                    {
                        Console.WriteLine("Rezervasyon Yapılamaz. Kapasite Dolu\nLütfen Başka Vagon Seçiniz:");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine(yolcusayisi + " Kişi Kadar Rezervasyon Başarılı Bir Biçimde Yapıldı\nVagon Numarası:2\nKişi Sayısı:" + yolcusayisi);
                        Console.ReadLine();
                    }
                    break;


                   
                    case 2:
                    Console.WriteLine("Yolcu Kapasitesi Dolu. Rezervasyon Yapamazsınız. ");
                    Console.ReadLine();
                    break;


                case 3:
                        int kapasite3 = 68;
                        Console.WriteLine("Rezervasyon Yapmak İstediğiniz Kişi Sayısını Giriniz: ");
                        int kisisayisi1 = Convert.ToInt32(Console.ReadLine());
                        int yolcularintoplami = (kapasite3 + kisisayisi1);

                        if (yolcularintoplami > 70)
                        {
                            Console.WriteLine("Rezervasyon Yapılamaz. Kapasite Dolu ");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine(kisisayisi1 + " Kişi Kadar Rezervasyon Başarılı Bir Biçimde Yapıldı\nVagon Numarası:3\nKişi Sayısı:" + kisisayisi1);
                            Console.ReadLine();
                        }
                        break;

                    case 4:
                        int kapasite4 = 60;
                        Console.WriteLine("Rezervasyon Yapmak İstediğiniz Kişi Sayısını Giriniz: ");
                        int kisisayisi4 = Convert.ToInt32(Console.ReadLine());
                        int yolcular = (kapasite4 + kisisayisi4);
                        if (yolcular > 70)
                        {
                            Console.WriteLine("Rezervasyon Yapılamaz. Kapasite Dolu");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine(kisisayisi4 + " Kişi Kadar Rezervasyon Başarılı Bir Biçimde Yapıldı\nVagon Numarası:4\nKişi Sayısı:" + kisisayisi4);
                            Console.ReadLine();
                        }
                        break;
                }
            }
        
    }
}