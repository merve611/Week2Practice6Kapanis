//1 - Aşağıdaki çıktıyı yazan bir program.
//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?

//Console.WriteLine(" Merhaba \n Nasılsın ? \n İyiyim \n Sen nasılsın ?");


//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.


//string name = "Merve";
//int yas = 28;
//Console.WriteLine(" Metinsel veri: " + name + " \n Tam sayı verisi " + yas);

//3 - Rastgele bir sayı üretip , ekrana yazdırınız.

//Random rnd = new Random();

//int sayi = rnd.Next(1,500);
//Console.WriteLine(sayi);


//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

//Random rnd = new Random();
//int sayi = rnd.Next(1,500);
//Console.WriteLine("Rasgele üretilen sayi : " +sayi);
//int kalan = sayi % 3;
//Console.WriteLine(sayi + " nin 3 e bölümünden kalan : " + kalan);


//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

//Console.WriteLine("Lütfen yaşınızı girin: ");
//int yas = Convert.ToInt32(Console.ReadLine());

//if(yas > 18)
//{
//    Console.WriteLine("+");
//}else if(yas < 18)
//{
//    Console.WriteLine("-");
//}


//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

//for(int i =0; i<10; i++)
//{
//    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
//}

//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.



//Console.WriteLine("Bir ünlü ismi yazını : ");
//string girisAd1 = Console.ReadLine();

//Console.WriteLine("Bir ünlü ismi daha yazını : ");
//string girisAd2 = Console.ReadLine();

//string deger = "";
//deger = girisAd1;
//girisAd1 = girisAd2;
//girisAd2 = deger;

//Console.WriteLine(girisAd1);
//Console.WriteLine(girisAd2);


//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.


//static void BenDegerDondurmem()
//{
//    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
//}
//BenDegerDondurmem();


//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.


// static int Toplama(int x, int y)
//{
//    int toplam = x + y;
//    Console.WriteLine(toplam);

//    return toplam;
//}
//Toplama(4, 5);


//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

//Console.WriteLine(" true veya false değerini giriniz : ");
//string giris = Console.ReadLine();
//string result = "";                 //fonksiyon içinde return edildikten sonra gelen string bu değişkene atanır

//if (giris =="true")                     //Kullanıcı true değerini girmişse 
//{
//    result = TrueFalseFunc(true);           //Fonksiyona bool deger olarak true ata
//    Console.WriteLine(result);              //return edilen değer resulta atandı onu ekranda göster
//}
//else if (giris == "false")              //Kullanıcı false değeri girmişse deger e false gönder ve ekrana "FALSE " yazsın 
//{
//    result = TrueFalseFunc(false);
//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine("Geçersiz giriş");          //Kullanıcı true veya false dışında bir değer girerse
//}

//static string TrueFalseFunc(bool deger) 
//{
//    if (deger)                      // kullanıcının girdiği deger true ise ekrana string " TRUE " YAZAR
//    {
//        return "TRUE";
//    }
//    else
//    {
//        return "FALSE";
//    }

//}



//11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
//int result;
//int yas1 = 45, yas2 = 89, yas3 = 21;


//static int EnYasli(int x, int y, int z)         //3 yaş alacağımız için 3 parametreli bir fonksiyon oluşturdum
//{
//    if (x > y && x > z)
//        return x;
//    else if (y > x && y > z)
//        return y;
//    else
//        return z;

//}
//result = EnYasli(yas1, yas2, yas3);
//Console.WriteLine("En büyüğünün yaşı : " + result);


//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

//int[] numbers = new int[20];                                        //kullanıcının girdiği sayıları atmak için bir dizi oluşturdum
//int count = 0;                                                      //dizinin indeksinin atanacağı değişken

//while (true)                                                        //bu döngüye herzaman girecek kullanıcı B girene kadar döngü devam eder
//{
//    Console.WriteLine("istediğiniz kadar sayı girin çıkmak isterseniz B harfine basıp Enter'layın : ");
//    string giris = Console.ReadLine();
//    int number = 0;

//    if(giris.ToUpper() == "B")
//    {
//        int maxValue = FindMaxValue(numbers);                       //
//        break;                                                      //Döngüden çıkmak için
//    }

//    if(int.TryParse(giris, out number))                             //
//    {
//        numbers[count] = number;
//        count++;
//    }
//}

//static int FindMaxValue(int[] numbers)
//{
//    int enBuyuk = -1;
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] > enBuyuk) 
//        {
//            enBuyuk = numbers[i];
//        }
//    }

//    Console.WriteLine("En büyük sayı : "+ enBuyuk);

//    return enBuyuk;
//}



//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

//Console.WriteLine("İlk ismi giriniz : ");
//string isim1 = Console.ReadLine();

//Console.WriteLine("İkinci ismi giriniz : ");
//string isim2 = Console.ReadLine();
//YerDegistir(ref isim1, ref isim2);

//static void YerDegistir(ref string name1, ref string name2)         //isimlerin yerlerini değiştiren metot
//{
//    string bos = name1;
//    name1 = name2;
//    name2 = bos;


//}


//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

//Console.WriteLine("Bir sayi giriniz : ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//bool tekMiCiftMi = TekCiftMi(sayi);                 //fonksiyon çağırılarak sonuç bir değişkene atanır
//Console.WriteLine(tekMiCiftMi);
//static bool TekCiftMi(int number)
//{
//    if(number % 2 == 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }


//}



//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

//Console.WriteLine("Hızınızı girin (km/saat cinsinden) : ");
//double hiz = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Zaman bilgisini girin (saat cinsinden) : ");
//double zaman = Convert.ToDouble(Console.ReadLine());

//double yol = YolHesapla(hiz, zaman);
//Console.WriteLine(yol);

//static double YolHesapla(double v, double t)
//{
//    return v * t;
//}



//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.


//double yaricap = 4;
//double piSayisi = 3.14;
//double alan = DaireninAlani(yaricap, piSayisi);
//Console.WriteLine(alan);

//static double DaireninAlani(double r, double pi)
//{
//    return pi * r * r;
//}



//17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.

//string cumle = "Zaman bir GeRi SayIm";
//string buyukHarf = cumle.ToUpper();
//string kucukHarf = cumle.ToLower();

//Console.WriteLine(buyukHarf);
//Console.WriteLine(kucukHarf);



//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string kelime = "    Selamlar   ";
Console.WriteLine(kelime);

string kelime2 = kelime.Trim();

Console.WriteLine(kelime2);