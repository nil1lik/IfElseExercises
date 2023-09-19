using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace If_Else_Alistirmalari
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                #region Örnek 1 
                /*Klavyeden öğrencinin 2 adet not bilgisi girildikten sonra, ortalama 50 ve üzerinde ise ekrana “Geçti” değilse “Kaldı” yazdıran programın Console uygulamasını yapalım.* 

                Console.WriteLine("Lütfen birinci notunuzu giriniz: "); //Öncelikle konsol ekranına kullanıcının ne yapacağını bilmesi için bir not yazıyoruz.
                int not1 = Convert.ToInt32(Console.ReadLine()); //Daha sonra ReadLine komutuyla kullanıcıdan bir not alıyoruz. Bu komut her zaman string değer alır bu sebeple Convert sınıfının ToInt32 komutuyla string değeri int değere dönüştürüp not1 değişkeninin içine atıyoruz.

                //Şimdi aynı yollarla ikinci notu girmesini isteyeceğiz.

                Console.WriteLine("Lütfen ikinci notunuzu giriniz: ");
                int not2 = Convert.ToInt32(Console.ReadLine()); //İkinci not için not2 adında farklı bir değişken atadık.

                Şimdi programı yönlendirmek için if/else komutlarından yardım alacağız.

                if ((not1 + not2) / 2 >= 50) //Ortalama almak için öncelikle parantez içinde not1 ve not2'yi topluyoruz daha sonra sonucu ikiye bölüyoruz. Parantez içine almamızın sebebi işlem önceliğine dikkat etmek ve kodların karışmamasıdır. >= ise büyük eşittir demektir. Yani not 50 veya 50'den yukarı olmalıdır. 
                {
                    Console.WriteLine("Sınavı Geçtiniz. Notunuz: " + (not1 + not2) / 2); //WriteLine ile konsola sonucu yazdırıyoruz. Metin değerini "" arasında yazdıktan sonra + ile değerleri birbirine ekliyoruz fakat matematiksel bir işlem olarak değil farklı değerlerin yani hem string hem de işlem içeren değerlerin beraber konsola yazdırılması için...
                }
                else
                {
                    Console.WriteLine("Sınavdan Kaldınız. Notunuz: " + (not1 + not2) / 2);
                }
                Console.ReadLine(); //Bu komutla da konsolu açık tutuyoruz. */
                #endregion

                #region Örnek 2
                /*Bir üniversitede öğrencilerin ortalamaları 50 ve üzerinde ise dersten başarılı sayılmaktadırlar. Öğrencinin vize notu ortalamaya % 40, final notu % 60 etki ettiği bildiğine göre öğrencilerin ders başarı durumlarını hesaplayan programı yapalım.

                Console.WriteLine("Lütfen vize notunuzu giriniz: ");
                 double vize = Convert.ToDouble(Console.ReadLine());
                 if (vize < 0 || vize > 100)
                 {
                     Console.WriteLine("Lütfen 0-100 arası bir parametre giriniz.");
                 }
                 else
                 {
                     Console.WriteLine("Lütfen final notunuzu giriniz: ");
                     double final = Convert.ToDouble(Console.ReadLine());
                     if (final < 0 || final > 100)
                     {
                         Console.WriteLine("Lütfen 0-100 arası bir parametre giriniz.");
                     }
                     else
                     {
                         double ortalama = (vize = vize * 0.40) + (final = final * 0.60);

                         if (ortalama >= 50)
                         {
                             Console.WriteLine("Sınavı geçtiniz. Notunuz: " + ortalama);
                         }
                         else
                         {
                             Console.WriteLine("Kaldınız. Notunuz: " + ortalama);
                         }
                     }
                 }

                 Console.ReadLine();  */
                #endregion

                #region Örnek 3
                /* Belirlenen kullanıcı adı ve şifre doğru girildiğinde “Giriş Başarılı”, yanlış girildiğinde “Girdiğiniz kullanıcı adı veya şifre hatalı” mesajı veren Console uygulamasını yapalım.
                string userName = "Nil";
                int pass = 123;

                Console.WriteLine("Lütfen kullanıcı adınızı giriniz: ");
                string userName2 = Console.ReadLine();
                if (userName == userName2)
                {
                    Console.WriteLine("Lütfen şifrenizi giriniz: ");
                    int pass2 = Convert.ToInt32(Console.ReadLine());
                    if (pass == pass2)
                    { Console.WriteLine("Başarılı bir şekilde giriş yaptınız."); }
                    else
                    {
                        Console.WriteLine("Şifre hatalı!");
                    }
                }
                else
                    Console.WriteLine("Kullanıcı adı hatalı!");

                Console.ReadLine();

                &&

                string userName, pass;
                Console.Write("Lütfen kullanıcı adınızı giriniz: ");
                userName = Console.ReadLine();
                Console.Write("Lütfen şifrenizi giriniz: ");
                pass = Console.ReadLine();

                if (userName == "Nil" || userName == "nil" && pass == "123")
                    Console.WriteLine("Başarılı bir şekilde giriş yaptınız!");
                else
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı! Lütfen tekrar deneyin.");
                Console.ReadLine(); */
                #endregion

                #region Örnek 4

                /*Klavyeden girilen sayının tek mi, çift mi olduğunu gösteren C# programını yazalım.

                Console.Write("Bir sayı giriniz: ");
                double num = Convert.ToDouble(Console.ReadLine());

                if (num % 2 == 0) //girilen sayının modunu % ile alıyoruz ve kalanı 0'a eşitse çift sayıdır diyoruz
                {
                    Console.WriteLine("Girdiğiniz sayı çifttir.");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı tektir.");
                }
                Console.ReadKey(); */
                #endregion

                #region Örnek 5

                /*Bir mağazada alınan ürünün fiyatı 100 Tl ve üzerinde ise 5 Tl olan kargo ücreti alınmamaktadır.Ürünün fiyatı girildiğinde toplam ödenmesi gereken tutarı gösteren programı yazalım.

                Console.WriteLine("Ürünün fiyatını giriniz: ");
                double fiyat = Convert.ToDouble(Console.ReadLine());

                if (fiyat >= 100)
                {
                    Console.WriteLine("100 TL ve üzeri alışverişe kargo bedava! Ödemeniz gereken tutar: " + fiyat);
                }
                else
                {
                    Console.WriteLine("Ödemeniz gereken tutar: " + (fiyat + 5) + " (+5 TL Kargo Ücreti)");
                }
                Console.ReadLine(); */
                #endregion

                #region Örnek 6

                /* Klavyeden girilen sayının negatif, pozitif veya sıfır olduğunu gösteren programın C# kodlarını yazalım.


                Console.WriteLine("Bir sayı giriniz: ");
                double girilenSayi = Convert.ToDouble(Console.ReadLine());


                if (girilenSayi < 0)
                {
                    Console.WriteLine("{0} negatif bir sayıdır.", girilenSayi);
                }
                else if (girilenSayi > 0)
                {
                    Console.WriteLine("{0} pozitif bir sayıdır.", girilenSayi);
                }
                else
                {
                    Console.WriteLine("Sıfır");
                }

                Console.ReadKey(); */
                #endregion

                #region Örnek 7

                /* Kullanıcıdan girdiği iki sayı ve yapılacak işlem türü(toplama, çıkarma, çarpma, bölme) seçildiğinde, sonucu hesaplayarak ekranda gösteren programı yazalım.

                double sayi1, sayi2;
                string islem;
                Console.Write("Birinci sayıyı giriniz: ");
                sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayıyı giriniz: ");
                sayi2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Yapmak istediğiniz işlemi yazınız ( +, - , / , x): ");
                islem = Console.ReadLine();

                if (islem == "+")
                {
                    double toplam = sayi1 + sayi2;
                    Console.WriteLine("Sonuç: " + toplam);
                }
                else if (islem == "-")
                {
                    double fark = sayi1 - sayi2;
                    Console.WriteLine("Sonuç: " + fark);
                }
                else if (islem == "x")
                {
                    double carpim = sayi1 * sayi2;
                    Console.WriteLine("Sonuç: " + carpim);
                }
                else if (islem == "/")
                {
                    double bolum = sayi1 / sayi2;
                    Console.WriteLine("Sonuç: " + bolum);
                }
                Console.ReadKey();

                veya

                double sayi1, sayi2, sonuc = 0;
                Console.Write("1. sayıyı giriniz: ");
                sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("2. sayıyı giriniz: ");
                sayi2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Yapmak istediğiniz işlem nedir? (+, -, x, /) > ");
                string islem = Console.ReadLine();

                if (islem == "+")
                {
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                }
                else if (islem == "-")
                {
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                }
                else if (islem == "x")
                {
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                }
                else if (islem == "/")
                {
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir parametre giriniz.");
                }

                Console.ReadLine(); */
                #endregion

                #region Örnek 8

                /*Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise, 2.üründen % 25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.

                Console.Write("Birinci ürünün fiyatını giriniz: ");
                double f1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci ürünün fiyatını giriniz: ");
                double f2 = Convert.ToDouble(Console.ReadLine());

                double indirim = f1 + (f2 * 0.75);
                double toplam = f1 + f2;

                if (toplam == 200)
                { Console.WriteLine("Ödemeniz gereken tutar: {0}TL", indirim); }
                else
                {
                    Console.WriteLine("Ödemeniz gereken tutar: {0}TL", toplam);
                }
                Console.ReadKey();

                &&

                Console.Write("Birinci ürünün fiyatını giriniz: ");
                double f1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci ürünün fiyatını giriniz: ");
                double f2 = Convert.ToDouble(Console.ReadLine());


                if ((f1+f2)==200)
                { Console.WriteLine("Ödemeniz gereken tutar: "+(f1+(f2*0.75))); }
                else
                {
                    Console.WriteLine("Ödemeniz gereken tutar: "+(f1+f2));
                }
                Console.ReadKey(); */
                #endregion
            }


        }


    }

}
    }
}
