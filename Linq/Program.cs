using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static class Okul
        {
            public static List<Ogrenci> Ogrenci { get; set; }
            public static List<Ders> Ders { get; set; }
            public static List<OgrenciDers> OgrenciDers { get; set; }

            static Okul()
            {
                Ogrenci = new List<Ogrenci>()
                    {
                        new Ogrenci()
                        {
                            ID= 1,Adi="Tunahan",Soyadi="Demir",Dogumyeri="Trabzon",Yas=19
                        },new Ogrenci()
                        {
                            ID= 2,Adi="Ahmet",Soyadi="Yılmaz",Dogumyeri="Ankara",Yas=12
                        },new Ogrenci()
                        {
                            ID= 3,Adi="Hasan",Soyadi="Çelik",Dogumyeri="Adıyaman",Yas=26
                        },new Ogrenci()
                        {
                            ID= 4,Adi="Burak",Soyadi="Al",Dogumyeri="İstanbul",Yas=36
                        },new Ogrenci()
                        {
                            ID= 5,Adi="Salih",Soyadi="Er",Dogumyeri="Kars",Yas=56
                        }
                    };

                OgrenciDers = new List<OgrenciDers>()
                {
                    new OgrenciDers() {DersId= 1,OgrId=1},
                    new OgrenciDers() {DersId= 1,OgrId=2},
                    new OgrenciDers() {DersId= 2,OgrId=3},
                    new OgrenciDers() {DersId= 2,OgrId=1},
                    new OgrenciDers() {DersId= 3,OgrId=2},
                };

                Ders = new List<Ders>() {

                    new Ders(){Id=1,DersAdi="Matematik"},
                    new Ders(){Id=2,DersAdi="Fizik"},
                    new Ders(){Id=3,DersAdi="Biyoloji"},

                };

            }

        }        
        static void Main(string[] args)
        {
            // 1) deferred mode

            var sonuc = Okul.Ogrenci;//Veri tabanından bu şekilde öğrenciler talep
            //edilirse kullanılacak olduğu yere kadar sorgu gitmez.

            foreach (var item in sonuc)
            {
                Console.WriteLine(item.Adi);//sorgu şimdi veritabanına yollanır.
            }

            // 2) immediate mode

            var sonuc1 = Okul.Ogrenci.ToList();//sorgu bu satır ile veritabanına yollanır.

            foreach (var item in sonuc1)
            {
                Console.WriteLine(item.Adi);
            }

            // 3) where sorguları

            var sonuc2 = Okul.Ogrenci.Where(o => o.Yas > 24);//yaşı 24ten büyük olanları getir

            // 4) oftype

            ArrayList dizi = new ArrayList();
            dizi.Add("Ankara");
            dizi.Add(2);
            dizi.Add('a');

            // string olan verileri çek diyebiliriz
            var stringSonuc = dizi.OfType<string>();

            // 5) orderby

            var sonuc3 = Okul.Ogrenci.OrderBy(o => o.Yas);//yaşa göre sırala diyebiliriz.küçükten büyüğe

            var sonuc4 = Okul.Ogrenci.OrderByDescending(o => o.Yas);//büyükten küçüğe

            // 6) thenby

            // orderby tek sütün içn çalışır, 2. bir sıralama yapmak istiyorsak thenby kullanırız.
            var sonuc5 = Okul.Ogrenci.OrderBy(o => o.Adi).ThenBy(o => o.Yas);

            // 7) groupby

            //doğum yeri aynı olanları gruplar
            var sonucgrp = Okul.Ogrenci.GroupBy(o => o.Dogumyeri);

            foreach (var item in sonucgrp)
            {
                Console.WriteLine("gruplanan şehir isimleri: " + item.Key +
                    " gruptaki eleman sayısı: " + item.Count());
            }

            // 8) join 

            var birlesmisSonuc = Okul.Ogrenci.Join(
                Okul.OgrenciDers,//join edilecek tablo                                 
                o => o.ID,//birincil anahtar
                od => od.OgrId,//yabancıl anahtar
                (o, od) => new
                {
                    //alınan tablolar
                    o,
                    od
                }

                );


            var birlesmisSonuc2 = Okul.Ogrenci.Join(
                Okul.OgrenciDers,//join edilecek tablo                                 
                o => o.ID,//birincil anahtar
                od => od.OgrId,//yabancıl anahtar
                (o, od) => new
                {
                    //bazı değerlerin alınması
                    o.Dogumyeri,
                    od.DersId
                }

                );

            // 9) select

            // öğrenci adı ve doğum yeri snc nesnesine atanmış durumda.

            var snc = Okul.Ogrenci.Select(o => new
            {

                ogrAdi = o.Adi,
                ogrdogumyeri = o.Dogumyeri
            });

            foreach (var item in snc)
            {
                Console.WriteLine(item.ogrAdi + " " + item.ogrdogumyeri
                    );
            }

            // 10) startswith, endswith, contains

            var sonuc6 = Okul.Ogrenci.Where(o => o.Adi.ToLower().StartsWith("se"));//adı se ile başlayan
            var sonuc7 = Okul.Ogrenci.Where(o => o.Adi.ToLower().EndsWith("a"));//adı a ile biten
            var sonuc8 = Okul.Ogrenci.Where(o => o.Adi.ToLower().Contains("da"));//adı da içeren

            // 11) single, singleordefault, first, firstordefault

            // tek değer dönerse sıkıntı yok, birden fazla değer dönerse veya 
            //hiç değer dönmezse hata alınır.
            var sonuc9 = Okul.Ogrenci.Single(o => o.ID == 1);

            // tek değer dönerse problem yok, birden fazla dönerse hata alınır.
            // hiç değer dönmezse null veya varsayılan değer alınır.
            var sonuc10 = Okul.Ogrenci.SingleOrDefault(o => o.ID == 100);

            // dönen değerlerin ilkini alır, hiç değer dönmezse hata alınır.
            var sonuc11 = Okul.Ogrenci.First(o => o.ID == 26);

            // dönen değerlerin ilkini alır, hiç değer dönmezse null veya varsayılan değer alınır.
            var sonuc12 = Okul.Ogrenci.FirstOrDefault(o => o.ID == 26);

        }
    }
}
