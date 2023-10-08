
//int a = 2;
//int b =3;
// a= b;
//Console.WriteLine(a);
//Console.WriteLine(b);

//int karesiAlinmisSayi = KaresiniAl(a);



//Console.WriteLine(karesiAlinmisSayi);

//int KaresiniAl(int sayi)
//{
//    return sayi * sayi;
//}

//string Sehir = "İstanbul";
//string plakamiz = PlakaVer(Sehir);

//string PlakaVer(string il)
//{
//    il += " 34 FB 1907";
//    return il;
//}

//Console.WriteLine(Sehir);


int a = 31;
int toplaXtendönendeğer = ToplaX(a);

Console.WriteLine(toplaXtendönendeğer);
Console.WriteLine(a);


Console.ReadLine();

int ToplaX(int sayilar)
{
    sayilar = 1;

    int total = sayilar + sayilar;

    return total;
}

int[] deneme = new int[] { 1, 22, 11, 8, 99 };

foreach (int item in deneme)
{
    Console.WriteLine(item);

}
int dizininToplamı = Topla(deneme);

Console.WriteLine("sonuç =" + dizininToplamı);


foreach (int item in deneme)
{
    Console.WriteLine(item);

}

/*
 * 31
 * 1
 * 22
 * 10
 * 8
 * 100
 * 
 */


int Topla(int[] sayilar)
{
    int total = 0;

    for (int i = 0; i < sayilar.Length; i++)
    {
        sayilar[i] = i * i * 2;

        total = total + sayilar[i];
    }
    return total;
}