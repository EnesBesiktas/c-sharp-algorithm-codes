
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ptg_final_çalışma
{
    internal class Program
    {


        #region dizi içindeki aynı karakterleri 1 kez yazan algoritma
        //input: mehmet
        //output: meht
        //static void Main(string[] args)
        //{

        //    string kelime = "mehmetmehmetahmet";
        //    string temp = "";
        //    temp += kelime[0];
        //    bool a = true;
        //    for (int i = 0; i < kelime.Length; i++)
        //    {

        //        for (int j = 0; j < temp.Length; j++)
        //        {
        //            if (temp[j] == kelime[i])
        //            {
        //                a = false;
        //                break;
        //            }
        //            else
        //            {
        //                a = true;
        //            }
        //        }
        //        if (a == true)
        //        {
        //            temp += kelime[i];
        //        }
        //    }
        //    Console.WriteLine(temp);

        //}
        #endregion

        #region 1 den 10 a kadar tam sayılar dizisinde eksik olan sayıları yazdıran algoritma 





        #endregion

        #region 1.METOT GERİYE DEĞER DÖNDÜREN VE PARAMETRE ALAN METOT ÖRNEĞİ

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("birinci sayıyı gir");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("ikinci sayıyı gir");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());
        //    toplama(sayi1, sayi2);
        //    //Console.WriteLine(toplama(sayi1, sayi2)); 
        //    Console.ReadLine();
        //}

        //static int toplama (int a, int b)
        //{
        //    int sonuc = a + b;
        //    Console.WriteLine(sonuc);
        //    return sonuc;
        //}
        #endregion

        #region 2.METOT GERİYE DEĞER DÖNDÜREN VE PARAMETRE ALMAYAN METOT ÖRNEĞİ
        //static void Main (string[] args)
        //{
        //    Console.WriteLine("toplam = " + toplama2());
        //}
        //static int toplama2()
        //{
        //    Console.Write("birinci sayıyı girin: ");
        //    int a = int .Parse(Console.ReadLine());
        //    Console.Write("ikinci sayıyı girin: ");
        //    int b = int .Parse(Console.ReadLine());
        //    int sonuc = a + b;
        //    return sonuc;
        //}

        #endregion

        #region 3. METOT GERİYE DEĞER DÖNDÜRMEYEN VE PARAMETRE ALAN METOT ÖRNEĞİ
        //static void Main(string[] args)
        //{
        //    Console.Write("birinci sayıyı gir: ");
        //    int sayı1 = int.Parse(Console.ReadLine());
        //    Console.Write("ikinci sayıyı gir: ");
        //    int sayı2 = int.Parse(Console.ReadLine());
        //    int sonuc = 0;
        //    toplama3(sayı1, sayı2,sonuc);
        //    Console.ReadLine();
        //}
        //static void toplama3(int a , int b,int sonuc)
        //{
        //    sonuc = a + b;
        //    Console.WriteLine("sonuç = " + sonuc );


        //}

        #endregion

        #region 4.METOT GERİYE DEĞER DÖNDÜRMEYEN VE PARAMETRE ALMAYAN METOT ÖRNEĞİ
        //static void Main(string[] args)
        //{
        //    toplama4();
        //}
        //static void toplama4()
        //{
        //    Console.Write("birinci sayıyı gir: ");
        //    int sayi1 = int.Parse(Console.ReadLine());
        //    Console.Write("ikinci sayıyı gir: ");
        //    int sayi2 = int.Parse(Console.ReadLine());

        //    int sonuc = sayi1 + sayi2;

        //    Console.WriteLine("sonuc= " + sonuc );
        //}

        #endregion

        #region Bağdaşık Sayı ( metot sorusu )
        //kullanıcıdan iki sayı alcaz ve sayıların kendisi hariç pbsler toplamları diğer sayıya eşitse 
        //bağdaşık sayı mı true false dönsün
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("birinci sayıyı gir");
        //    int sayi1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("ikinci sayıya gir");
        //    int sayi2 = int.Parse(Console.ReadLine());

        //    bağdaşıkMi(sayi1, sayi2);

        //}
        //static int pozitifBolen(int a)
        //{
        //    int toplam = 0;
        //    for (int i = 1; i < a; i++)
        //    {
        //        if (a % i == 0)
        //        {
        //            toplam = i + toplam;
        //        }
        //    }
        //    return toplam;
        //}
        //static void bağdaşıkMi(int a, int b)
        //{
        //    pozitifBolen(a);
        //    if (a == pozitifBolen(b) && b == pozitifBolen(a))
        //    {
        //        Console.WriteLine("aferin la bağdaşık");
        //    }
        //    else
        //    {
        //        Console.WriteLine("bok bağdaşık haniiiğğ");
        //    }
        //}


        #endregion

        #region  REPLACE METOT ÖRNEĞİ

        //static void Main(string[] args)
        //{
        //    string metin = "ahmet";

        //    Console.WriteLine("replace yazım: " + replace(metin, 'a', 'e'));
        //}
        //static string replace(string metin, char a, char b)
        //{
        //    string metin2 = "";
        //    char[] dizi = new char[metin.Length];

        //    for (int i = 0; i < metin.Length; i++)
        //    {
        //        dizi[i] = metin[i];
        //    }
        //    for (int i = 0;i<dizi.Length;i++)
        //    {
        //        if (dizi[i] == a)
        //        {
        //            dizi[i]= b; 
        //        }
        //        metin2 += dizi[i];
        //    }

        //    return metin2;
        //}


        #endregion

        #region GİRİLEN POZİTİF TAM SAYININ BASAMAK SAYISINI BULAN KOD 

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("sayıyı giriniz ");
        //    long sayi = long.Parse(Console.ReadLine());

        //    Console.WriteLine("basamak sayısı: " + basamak(sayi));
        //}

        //static long basamak( long sayi )
        //{
        //    long bas = 0;
        //    while ( sayi>0 )
        //    {
        //        bas++;
        //        sayi = sayi / 10;
        //    }

        //    return bas;
        //}
        #endregion

        #region VERİLEN SAYININ BASAMAK DEĞERLERİNİ YAZDIRAN KOD 
        // input: 154
        //output: 100 50 4
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("sayıyı giriniz");
        //    long sayi = long.Parse(Console.ReadLine());

        //    basDeğeriYaz(sayi);

        //}
        //static long basamak(long sayi)
        //{
        //    long bas = 0;
        //    while (sayi > 0)
        //    {
        //        bas++;
        //        sayi = sayi / 10;
        //    }

        //    return bas;
        //}
        //public static void basDeğeriYaz(long sayi)
        //{
        //    int b = 10;
        //    for (long i = 0; i < basamak(sayi); i++)
        //    {
        //        long a = sayi % b;
        //        Console.WriteLine(a);
        //        sayi = sayi - a;
        //        b *= 10;

        //    }

        //}


        #endregion

        #region VERİLEN STRİNG İÇİN DE ARANAN STRİNG VARSA TRUE DÖNCEK (CONTAİNS)
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("metninizi giriniz");
        //    string metin = Console.ReadLine();
        //    Console.WriteLine("aranan metini giriniz");
        //    string aranan = Console.ReadLine();
        //    contains(metin, aranan);
        //}
        //static string contains(string metin, string aranan)
        //{
        //    string tutan = "";

        //    for (int i = 0; i < metin.Length; i++)
        //    {
        //        tutan += metin[i];
        //        if (tutan == aranan)
        //        {
        //            Console.WriteLine("aranan metin var");
        //        }
        //        else
        //        {
        //            tutan = Convert.ToString(metin[i + 1]);
        //            continue;
        //        }
        //    }
        //    return tutan;
        //}


        #endregion

        #region VERİLEN STRİNGİ VERİLEN KARAKTERİ GÖRÜNCE BÖLÜYOR (SPLİT)
        //input: kakakakakakakak
        //output: kkkkkkkk
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("lütfen metni giriniz");
        //    string metin = Console.ReadLine();
        //    Console.WriteLine("bölme karakterini giriniz");
        //    char ayıran = char.Parse(Console.ReadLine());
        //    foreach (var item in split(metin, ayıran))
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //static string[] split(string metin, char ayıran)
        //{
        //    string boş = "";
        //    int j = 0;
        //    int sayaç = 0;
        //    for (int i = 0; i < metin.Length; i++)
        //    {
        //        if (metin[i] == ayıran)
        //        {
        //            sayaç++;
        //        }
        //    }
        //    string[] metin2 = new string[sayaç + 1];
        //    for (int i = 0; i < metin.Length; i++)
        //    {
        //        if (metin[i] != ayıran)
        //        {
        //            boş += metin[i];
        //        }
        //        else
        //        {
        //            metin2[j] = boş;
        //            boş = "";
        //            j++;
        //        }
        //    }
        //    metin2[j] = boş;
        //    return metin2;
        //}

        #endregion

        #region VERİLEN METNİN BAŞLANGICININ BELİRTİLEN METNİN EŞLEŞİP EŞLEŞMEDİĞİNİ BULAN (STARTSWİTH)
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("metninizi giriniz");
        //    string metin = Console.ReadLine();
        //    Console.WriteLine("aranan metini giriniz");
        //    string aranan = Console.ReadLine();
        //    startswith(metin, aranan);
        //}
        //static string startswith(string metin, string aranan)
        //{
        //    string tutan = "";

        //    for (int i = 0; i < metin.Length; i++)
        //    {
        //        tutan += metin[i];
        //        if (tutan == aranan)
        //        {
        //            Console.WriteLine("aranan string var ");
        //        }
        //        else
        //        {
        //            Console.WriteLine("aranan string haniiii");
        //            break;

        //        }
        //    }
        //    return tutan;
        //}




        #endregion

        #region VERİLEN METNİN SONUNUN BELİRTİLEN METİNLE EŞLEŞİP EŞLEMEDİĞİNİ BULAN (ENDSWİTH)
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("metni gir");
        //    string metin = Console.ReadLine();
        //    Console.WriteLine("aranan kısımı gir");
        //    string aranan = Console.ReadLine();
        //    endswith(metin, aranan);
        //}
        //static void endswith(string metin, string aranan)
        //{
        //    string tutan = "";
        //    for (int i =metin.Length-aranan.Length; i < metin.Length; i++)
        //    {
        //        tutan += metin[i];
        //        if (tutan == aranan)
        //        {
        //            Console.WriteLine("aranan endswith var");
        //        }
        //        else
        //        {
        //            continue;

        //        }
        //    }

        //}


        #endregion

        #region  VERİLEN METNİN SONUNUN BELİRTİLEN METİNLE EŞLEŞİP EŞLEMEDİĞİNİ BULAN (ENDSWİTH) bool çözüm
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("metni gir");
        //    string metin = Console.ReadLine();
        //    Console.WriteLine("aranan kısımı gir");
        //    string aranan = Console.ReadLine();
        //    endswith(metin, aranan);
        //}
        //static void endswith(string metin, string aranan)
        //{
        //    bool n = false;
        //    string tutan = "";
        //    for (int i = metin.Length - aranan.Length; i < metin.Length; i++)
        //    {
        //        tutan += metin[i];
        //        if (tutan == aranan)
        //        {
        //            n = true;
        //        }
        //    }
        //    Console.WriteLine(n);

        //}
        #endregion

        #region TERSİDE DÜZÜDE ASAL SAYI OLAN (LASA SAYISI)
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("sayıyı giriniz");
        //    int sayi = int.Parse(Console.ReadLine());
        //    tersinibulan(sayi);
        //}
        //static int basamaksayısı(int sayi)
        //{
        //    int sayac = 0;

        //    while (sayi>0)
        //    {
        //        sayac++;
        //        sayi = sayi / 10;
        //    }
        //    return sayac;
        //    int basamak = sayac;
        //}
        //static int tersinibulan(int sayi)
        //{

        //}
        #endregion

        #region Faktöriyel bulma
        //static void Main(string[] args)
        //{
        //    başadön:

        //    Console.WriteLine("lütfen faktöriyelini bulmak istediğiniz sayıyı giriniz");

        //    int sayi = int.Parse(Console.ReadLine());

        //    Console.WriteLine("faktöriyeli: " + faktöriyelBul(sayi));
        //    goto başadön;

        //}
        //static int faktöriyelBul(int sayi)
        //{

        //    int faktöriyel = 1;
        //    if (sayi == 0) { faktöriyel = 0; }
            
        //    for (int i = 1; i <= sayi; i++)
        //    {
        //        faktöriyel = faktöriyel * i;
        //    }
        //    return faktöriyel;

        //}



        #endregion

        #region Fibonacci 




        #endregion
        
        #region Deneme

        static void Main(string[] args)
        {

        Console.WriteLine("merhaba");
        }

		#endregion



	}
}
