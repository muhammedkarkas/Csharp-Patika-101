namespace operatorler
{   
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Atama ve İşlem Atama!");
        
        //ATAMA VE İŞLEMLİ ATAMA
        int x = 3;
        Console.WriteLine("x :" + x);
        int y = 3;
        Console.WriteLine("y :" + y);
        y += 2; // y = y + 2 anlamına gelmektedir.
        x *= 5; // x = x * 5 anlamına gelmektedir.

        Console.WriteLine("x :" + x); //x = 15 

        Console.WriteLine("y :" + y); // y = 5

        //MANTIKSAL OPERATÖRLER

        //Her dilde olduğu gibi veya ve değil ifadeleridir.Şekilleri tıpkı javada olduğu gibidir.
        // &&, ||, ! ifadeleri kullanılmaktadır.

        bool isSuccess = true;
        bool isCompleted = false;

        //if bloklarında birden fazla işlem yapılacaksa eğer süslü parantez kullanılma ancak tek işlem yapılacaksa eğer süslü paranteze gerek yoktur.

        if (isSuccess && isCompleted)  //Her iki koşulda true ise çıktı verir (true ve false = false)
            Console.WriteLine("Perfect");

        if (isSuccess || isCompleted)  //Her ikisinden biri true ise çıktı verir (True veya false = true)
            Console.WriteLine("Great");

        if (isSuccess && !isCompleted) //true-true olduğu durumda çıktı verir (true ve true = true)
            Console.WriteLine("Fine");

        /*
        Kodu çalıştırdığımızda perfect kısmını atlar çünkü ve durumu kullanılmakta yani her ikisinin de true olması gerekiyor ki ifade karşılansın.
        Diğer ifadelerde true çıktısı elde edilebildiği için Great ve Fine ifadelerini ekrana çıktı olarak verecektir.
        */


        //İLİŞKİSEL OPERATÖRLER

        // <, >, <=, >=, ==, != ifadeleri kullanılmaktadır.

        int a = 3;
        int b = 4;
        bool sonuc = a<b; //Sonuc a < b ise true olacaktır.

        Console.WriteLine(sonuc); //True 

        sonuc = a>b;
        Console.WriteLine(sonuc); //False

        sonuc = a==b;
        Console.WriteLine(sonuc); //False

        sonuc = a >= b;
        Console.WriteLine(sonuc); //False

        sonuc = a <= b;
        Console.WriteLine(sonuc); //True

        sonuc = a != b;
        Console.WriteLine(sonuc); //True

    }
  }
}