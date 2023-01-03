
BaşlangıcEkrani();

void BaşlangıcEkrani(){

Console.WriteLine("Girmiş olduğunuz sayilardan çift olanları gösteren işlem için : 1 ");
Console.WriteLine("Girmiş olduğunuz sayilardan eşit veya tam bölünenleri gösteren işlem için : 2 ");
Console.WriteLine("Girmiş olduğunuz kelimeleri tersten sıralayan işlem için : 3 ");
Console.WriteLine("Girmiş olduğunuz cümledeki harf ve kelime toplamlarını gösteren işlem için : 4 ");
Console.WriteLine("Yapmak istediğiniz işlemin sayisini belirtin: ");
int islemsayisi=Convert.ToInt32(Console.ReadLine());

switch (islemsayisi)
{
    case 1:
    Birinci();
    break;


    case 2:
    Ikinci();
    break;

    case 3:
    Ucuncu();
    break;

    case 4:
    Dorduncu();
    break;

    default:
    Console.WriteLine("Lütfen Geçerli bir işlem sayisi giriniz!");
    break;
}
}













void Birinci(){
//1//
Console.WriteLine("Lütfen pozitif bir tam sayi giriniz");
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen girmiş olduğunuz sayi adedince pozitif tam sayilar giriniz");
int[] sayilarim=new int[n];
int sayac=1;
for (int i = 0; i < n; i++)
{

    Console.Write(sayac+". sayiyi girin: ");
    sayilarim[i]=Convert.ToInt32(Console.ReadLine());
    sayac++;
}

Console.Write("Girmiş olduğunuz sayilardan çift olanlar şunlardır: ");
foreach (int item in sayilarim)
{
    if (item%2==0)
    {
        Console.Write(item+" ");
    }
}
Tekrar();
}




//2//
 void Ikinci(){

Console.WriteLine("Lütfen pozitif iki tam sayi giriniz");
Console.Write("Birinci Tam sayi: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.Write("İkinci Tam sayi: ");
int m= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen girmiş olduğunuz birinci sayi adedince pozitif tam sayilar giriniz");
int[] sayilarim=new int[n];
int sayac=1;
for (int i = 0; i < n; i++)
{

    Console.Write(sayac+". sayiyi girin: ");
    sayilarim[i]=Convert.ToInt32(Console.ReadLine());
    sayac++;
}

Console.Write("Girmiş olduğunuz sayilardan "+m+"'e eşit veya tam bölünenler şunlardır: ");
foreach (int item in sayilarim)
{
    if (item%m==0 || item==m)
    {
        Console.Write(item+" ");
    }
}
Tekrar();
}



//3//
 void Ucuncu(){

Console.WriteLine("Lütfen pozitif iki tam sayi giriniz");
Console.Write("Birinci Tam sayi: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen girmiş olduğunuz birinci sayi adedince kelimeler giriniz");
string[] kelimelerim=new string[n];
int sayac=1;
for (int i = 0; i < n; i++)
{

    Console.Write(sayac+". kelimeyi girin: ");
    kelimelerim[i]=Console.ReadLine();
    sayac++;
}
Array.Reverse(kelimelerim);

Console.Write("Girmiş olduğunuz kelimelerin sondan başa doğru yazılışı şöyledir: ");
for (int i = 0; i < n; i++)
{
    
    Console.Write(kelimelerim[i]+" ");
}
Tekrar();
}



//4//
 void Dorduncu(){

Console.Write("Lütfen Bir Cümle Yaziniz: ");
string n= Console.ReadLine();
int harfsayaci=0;
int kelimesayaci=1;
foreach (char item in n)
{
    if (item==' ')
    {
        kelimesayaci++;
        continue;

    }
    harfsayaci++;
}
Console.Write("Girdiğiniz Cümledeki kelimelerin toplam sayisi: "+kelimesayaci);
Console.WriteLine();
Console.Write("Girdiğiniz Cümledeki harflerin toplam sayisi: "+harfsayaci);

Tekrar();



}



void Tekrar(){
     Console.WriteLine();
    Console.WriteLine("Başka işlem Yapmak ister misiniz? E , H  ");
    char cevap= Convert.ToChar(Console.ReadLine());
    if (cevap=='E'|| cevap== 'e')
    {
        Console.Clear();
        BaşlangıcEkrani();
    }
    

}