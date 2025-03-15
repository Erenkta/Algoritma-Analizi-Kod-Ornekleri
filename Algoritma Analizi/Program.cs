// See https://aka.ms/new-console-template for more information
using Algoritma_Analizi;
using Algoritma_Analizi.Hafta_1;
using Algoritma_Analizi.Hafta_2;
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
int maxSum = subArraySum.MaxSubarraySum(subArray);

Console.WriteLine($"Maksimum Alt Dizi Toplamı: {maxSum} ");

Console.WriteLine("  \n Zaman karmaşıklığı : \n " +
    "Omega ( En iyi durum )   : n log(n) \n " +
    "Theta ( Ortalama durum ) : n log(n) \n " +
    "Big-O ( En kötü durum )  : n log(n) \n");




Console.WriteLine("----------------------------------------------------------------- \n");

