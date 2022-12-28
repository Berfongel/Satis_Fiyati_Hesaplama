// See https://aka.ms/new-console-template for more information
int alıs_fiyati, vergi_orani, kâr_orani,satis_fiyati;
Console.WriteLine("Alış fiyatını yazınız : ");
alıs_fiyati = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vergi oranını yazınız : ");
vergi_orani = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kâr oranını yazınız : ");
kâr_orani = Convert.ToInt32(Console.ReadLine());

satis_fiyati=alıs_fiyati + (alıs_fiyati*vergi_orani)/100 + (alıs_fiyati*kâr_orani)/ 100;
Console.WriteLine("Satış fiyatınız : " + satis_fiyati);

