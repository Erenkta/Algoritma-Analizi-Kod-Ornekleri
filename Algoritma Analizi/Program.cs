// See https://aka.ms/new-console-template for more information
using Algoritma_Analizi;
using Algoritma_Analizi.Hafta_1;
using Algoritma_Analizi.Hafta_2;
using Algoritma_Analizi.Hafta_3;
using System.Runtime.InteropServices;


Console.WriteLine("Algoritma Analizi Dersi Kod Örnekleri : ");
Console.WriteLine("----------------------------------------------------------------- \n");

int[] arr = { 4, 47, 8, 64, 34, 11, 90, 15, 25, 12, 22 };
Sort sort = new Sort();

Console.WriteLine("1- Bubble Sort Algoritması \n\n");

Console.WriteLine($"Sıralama öncesi array :");
ArrayLogger.PrintArray(arr);
Console.WriteLine("\n");
sort.BubbleSort(arr);
Console.WriteLine($"Sıralama Sonrası array :");
ArrayLogger.PrintArray(arr);

Console.WriteLine("  \n Zaman karmaşıklığı : \n " +
    "Omega ( En iyi durum )   : n \n " +
    "Theta ( Ortalama durum ) : n^2 \n " +
    "Big-O ( En kötü durum )  : n^2 \n");

Console.WriteLine("----------------------------------------------------------------- \n");

Console.WriteLine("2- Insertion Sort Algoritması \n\n");

Console.WriteLine($"Sıralama öncesi array :");
ArrayLogger.PrintArray(arr);
Console.WriteLine("\n");
sort.InsertionSort(arr);
Console.WriteLine($"Sıralama Sonrası array :");
ArrayLogger.PrintArray(arr);

Console.WriteLine("  \n Zaman karmaşıklığı : \n " +
    "Omega ( En iyi durum )   : n \n " +
    "Theta ( Ortalama durum ) : n^2 \n " +
    "Big-O ( En kötü durum )  : n^2 \n");

Console.WriteLine("----------------------------------------------------------------- \n");

MaxSubArraySum subArraySum = new MaxSubArraySum();
int[] subArray = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
Console.WriteLine($"Alt dizi toplamı bulunacak array ( Böl ve Fethet ile ) :");
ArrayLogger.PrintArray(subArray);
int maxSum = subArraySum.MaxSubarraySum(subArray);

Console.WriteLine($"\nMaksimum Alt Dizi Toplamı: {maxSum} ");

Console.WriteLine("  \n Zaman karmaşıklığı : \n " +
    "Omega ( En iyi durum )   : n log(n) \n " +
    "Theta ( Ortalama durum ) : n log(n) \n " +
    "Big-O ( En kötü durum )  : n log(n) \n");



Console.WriteLine("----------------------------------------------------------------- \n");
KadeneSubArray kadene = new KadeneSubArray();
int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
Console.WriteLine($"Alt dizi toplamı bulunacak array ( Kadene ile ) :");
ArrayLogger.PrintArray(nums);
Console.WriteLine("\nMaksimum Alt Dizi Toplamı: " + kadene.MaxSubarray(nums));

Console.WriteLine("  \n Zaman karmaşıklığı : \n " +
    "Omega ( En iyi durum )   : n \n " +
    "Theta ( Ortalama durum ) : n \n " +
    "Big-O ( En kötü durum )  : n \n");

Console.WriteLine("----------------------------------------------------------------- \n");
Power power = new Power();
int a = 2;
int b = 5;
Console.WriteLine($"{a} üzeri {b} sonucu: " + power.PowerOfNumber(a, b));

Console.WriteLine("  \n Zaman karmaşıklığı (a^b durumu için) : \n " +
    "Omega ( En iyi durum )   : b \n " +
    "Theta ( Ortalama durum ) : b \n " +
    "Big-O ( En kötü durum )  : b \n");

Console.WriteLine("----------------------------------------------------------------- \n");
