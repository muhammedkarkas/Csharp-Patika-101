namespace tipdonusumleri
{
    class Program
    {  
        public static void Main(string[] args)
        {
            //TİP DÖNÜŞÜMLERİ
            
            
            /*Implicit Conversion(Bilinçsiz Dönüşüm)
            Düşük kapasiteli bir değişkenin kendinden daha yüksek kapasiteli başka bir değişkene atanma işlemidir.
            Bir Parse veya Convert yazmamıza gerek kalmadan çevirme işlemini bizim yerimize makine yapmaktadır.
            */

            Console.WriteLine("***Implicit Conversion***");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d : " + d); //Çıktı 45

            long h = d;
            Console.WriteLine("h : " + h); //Çıktı 45

            float i = h;
            Console.WriteLine("i : " + i); //Çıktı 45

            string e = "mami";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g : " + g); //Çıktı mamik45 olur 
            //Object tipinde bir string bir char ve bir de integer veritipindeki 3 değişkeni birleştirebiliyorum ve herhangi bir hata almıyorum.

            Console.WriteLine("***********************************");
            
            /*Explicit Conversion(Bilinçli Dönüşüm)
            C# içerisinde bilinçli olarak yapılan tip dönüştürmelerdir.Aslında C# ın kendi kendine yapamadığı dönüşümlerdir.Convert ve Parse
            parametrelerini kullanarak yapılacak olan dönüşümü derleyiciye belirtmemiz gerekmektedir.
            */

            Console.WriteLine("***Explicit Conversion***");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y : " + y); //Çıktı 4

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t : " + t); //Çıktı 100

            float w = 10.3f;
            byte v = (byte)w;  //Float bir reel sayı ve byte a çevirilirken tam sayı olan kısmı alınmaktadır.Çevirimlerde veri kaybı yaşanabilmektedir.
            Console.WriteLine("v : " + v); //Çıktı 10 

            Console.WriteLine("***********************************");
            
            Console.WriteLine("***ToString Metodu***");
            // *** ToString Metodu ***
            //aldığı veriyi stringe çevirmektedir.

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy : " + yy ); //Çıktı 6

            string zz = 12.5f.ToString();
            Console.WriteLine("zz : " + zz); //Çıktı 12.5


            //System.Convert
            Console.WriteLine("***System.Convert***");
            string s1 = "10", s2 = "20";

            int sayi1;
            int sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1); //string to integer
            sayi2 = Convert.ToInt32(s2); //string to integer
            toplam = sayi1 + sayi2 ;
            Console.WriteLine("Toplam : " + toplam); //Çıktı 30


            //PARSE
            Console.WriteLine("***PARSE METHODU***");
            ParseMethod();

        }

        public static void ParseMethod() //Static metotlar içerisinde ancak static olan metotlar kullanılabilir
        {
            string metin1 = "10";
            string metin2 = "10,25";

            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1 : " + rakam1); //Çıktı 10
            Console.WriteLine("double1 : " + double1); //Çıktı 1025
        }
    }
    
}
