namespace tipdonusumleri
{
    class Program
    {  
        public static void Main(string[] args)
        {//
            //try //try içerisine hataya neden olabilecek kod yazılmaktadır
            //{
            //    Console.WriteLine("Bir sayı giriniz : ");
            //    int sayi = Convert.ToInt32(Console.ReadLine()); //İntegera çevirilemeyecek bir değer geldiğinde burdan hata fırlatılacaktır
            //    Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);             
            //}
            //catch(Exception ex) //Exception classından gelecek olan hataya ex diyoruz.
            //{
            //    Console.WriteLine("Hata : " + ex.Message.ToString()); //string bir ifade yazdığımızda girilen format uygun değil şeklinde bir hata vermekte
            //}
            //finally //Kod hata alsın ya da almasın çalıştırmamızı istediğimiz başka bir kod bloğu varsa onu finally içerisine yazıyoruz.
            //{
            //    Console.WriteLine("İşlem Tamamlandı...");
            //} 

            try
            {
                //int a = int.Parse(null); //ArgumentNullException
                //int a = int.Parse("test"); //FormatException
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex) //null girilmesi durumda alınacak hata formatıdır
            {
                Console.WriteLine("Boş Değer Girdiniz...");
                Console.WriteLine(ex);
            }
            catch(FormatException ex) //Yanlış formatta bir veri girilmesi durumunda kullanılan hata formatıdır.
            {
                Console.WriteLine("Veri Tipi uygun değil...");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz...");
                Console.WriteLine(ex);
            }
        
        }
    }
    
}