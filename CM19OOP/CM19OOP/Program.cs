// See https://aka.ms/new-console-template for more information
using CM19OOP.Classes;

Console.WriteLine("Hello, World!");

// bir classtan nesne oluşturma 
// ClassIsmi-nesneAdi = new ClassIsmi();
Insan i = new Insan();
i.adi = "şule"; // i değişkenine şule değerini sakla dedim 
i.soyadi = "Asilsoy";
i.yas = 22 ;
i.cinsiyet = false;
// metodu çağırmak 
i.uyu("Sema","Asilsoy"); // insan class'ı içerisindeki uyuyoru çağırdım
i.uyu(i.adi,i.soyadi); 

Araba a = new Araba();
a.modeli = "MERCEDES";
a.renk = "siyah";
a.km = 24.935;
a.yil = 2002;
a.git("BMW","beyaz");
a.git(a.modeli,a.renk);

Matematik m = new Matematik();
//1.yöntem = 
int gelenDeger = m.topla(5, 5);
Console.WriteLine("toplam :" + gelenDeger);
//2.yöntem=
Console.WriteLine("toplam 2. yöntem :" + m.topla(10, 10));
Console.WriteLine("çıkarma sonucu:" + m.cikar(5, 5));
Console.WriteLine("Çarpım sonucu:"+ m.carp(10,10));
Console.WriteLine("bölüm sonucu:"+ m.bol(25,5));

Anne an = new Anne();// bir classı başka bi classtan türetiyoruz.
an.adi = "şükran";
an.soyadi = "oğuz";
an.ekranaYaz(an.adi,an.soyadi);
an.oku(an.adi);

Baba b = new Baba();
b.ekranaYaz("salih", "asilsoy");
b.oku("salih");

Çocuk C = new Çocuk();
C.ekranaYaz("şule", "asilsoy");

BMW bm = new BMW();
bm.arabanınVitesi("BMW","Düz viteslidir");

Mercedes me =new Mercedes();
me.arabanınVitesi("Mercedes","Otomatik viteslidir");

Porsche p =new Porsche();
p.arabanınVitesi("Porsche","Otomatik viteslidir.");

Togg t = new Togg();
t.arabanınVitesi("Togg", "Otomatik viteslidir");

Audi Au = new Audi();
Au.arabanınVitesi("Audi", "Otomatik viteslidir");

Toyota to = new Toyota();
to.arabanınVitesi("Toyota", "Düz viteslidir");

AkilliÇocuk ak = new AkilliÇocuk();
ak.adi = "Şule ";
ak.soyadi = "Asilsoy";
ak.sifat = "Akıllıdır";
ak.adSoyadSifatYaz(ak.adi,ak.soyadi,ak.sifat);

UsluÇocuk us = new UsluÇocuk();
us.adSoyadSifatYaz("Sema","Asilsoy","Usludur");









