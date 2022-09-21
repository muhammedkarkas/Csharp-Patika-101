namespace if_else_if
{
    class Program
    {  
        public static void Main(string[] args)
        {
            int time = DateTime.Now.Hour; //Kodu çalıştırdığımız esnadaki tarih ve saati alan parametredir.

            if (time >= 6 && time < 11) //saat 6 dan büyük ve eşit aynı zamanda 11 den küçükse bu blok içerisindeki kod çalışır
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <= 18) //Kodun çalıştırıldığı saate göre dönecek olan true-false ifadesi değişiklik gösterecektir.
            {
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }
            //Bu şekilde alt alta tek tek yazmak dışında 
            string sonuc = time<=18 ? "İyi Günler" : "İyi Geceler";
            //Console.WriteLine(sonuc);
            /*
            yukarıda ilk yazılan koşul çalışırsa eğer soru işaretinden sonraki ilk ifade çalışacaktır. İlk parametreden sonra : iki nokta
            işareti değilse anlamını taşımakta ve : işaretinden sonra değilse koşulu sağlandığında kullanıcıya verilmek istenen çıktı girilecektir.
            sonuc değişkeni için belirtilen koşullu ifade direkt olarak çıktı kalıbının içerisinde de yazılabilirdi.Ancak anlaşılır olması için
            bir değişkene atamak tercih edildi.

            Aşağıdaki sonuc değişkeninde görüldüğü gibi ? ve : ile ise ve değilse kalıplarını kullandık.Buna göre şart aralıklarının çıktılarını uygun sırayla değişkene atadık.
            Daha sonra console ile ekrana çıktısını verdik ve herhangi bir hata almadan ekrana çıktımızı verdik.
            Yanyana uzun tanımlamalar yapmak okunabilirlik açısından zordur.Oluşturacağımız şart bloğu sayısına göre yanyana veya altalta nasıl yapacağımıza karar vereceğiz.
            */

            sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);

        }
    }
}