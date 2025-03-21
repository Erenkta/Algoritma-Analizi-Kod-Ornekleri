# Algoritma Analizi Dersi Kod Örnekleri

Bu proje, "Algoritma Analizi" dersine yönelik temel sıralama ve algoritma örneklerini içeren bir konsol uygulamasıdır. Proje, temel algoritmaların nasıl çalıştığını anlamaya yardımcı olmak için çeşitli sıralama algoritmaları ve bir dizi hesaplama işlemi sunar. Kod örnekleri, Bubble Sort, Insertion Sort, Kadane's Algorithm, Böl ve Fethet (Divide and Conquer) ile maksimum alt dizi toplamı ve üs alma (Power of Number) gibi popüler algoritmalar üzerinde odaklanmaktadır.

## İçerik

Bu uygulama aşağıdaki algoritmaların örneklerini içerir:

1. *Bubble Sort Algoritması*
   - Sıralama algoritmalarından biri olan Bubble Sort, bir dizi elemanını ardışık olarak karşılaştırarak ve yer değiştirerek sıralar.
   - Zaman karmaşıklığı: 
     - En iyi durum (Omega): n 
     - Ortalama durum (Theta): n^2
     - En kötü durum (Big-O): n^2

2. *Insertion Sort Algoritması*
   - Insertion Sort, her bir elemanı sırasıyla uygun pozisyonda yerleştirerek diziyi sıralar.
   - Zaman karmaşıklığı: 
     - En iyi durum (Omega): n 
     - Ortalama durum (Theta): n^2
     - En kötü durum (Big-O): n^2

3. *Maksimum Alt Dizi Toplamı (Kadane's Algorithm)*
   - Kadane algoritması, bir dizideki maksimum alt dizi toplamını hızlı bir şekilde hesaplamak için kullanılan etkili bir algoritmadır.
   - Zaman karmaşıklığı:
     - En iyi durum (Omega): n
     - Ortalama durum (Theta): n
     - En kötü durum (Big-O): n

4. *Maksimum Alt Dizi Toplamı (Böl ve Fethet)*
   - Böl ve Fethet algoritması kullanarak bir dizinin maksimum alt dizi toplamını hesaplar.
   - Zaman karmaşıklığı:
     - En iyi durum (Omega): n log(n)
     - Ortalama durum (Theta): n log(n)
     - En kötü durum (Big-O): n log(n)

5. *Üs Alma Algoritması (Power of Number)*
   - Bu algoritma, bir sayının başka bir sayıya üssünü hesaplar.
   - Zaman karmaşıklığı:
     - En iyi durum (Omega): b 
     - Ortalama durum (Theta): b
     - En kötü durum (Big-O): b
6. *Dizi ile oluşturulmuş bir yapıya CRUD işlemleri*  
   - Zaman karmaşıklığı:  
   - CRUD Zaman karmaşıklığı:  
     - Create  : O(1), Başa Ekleme : O(n) , Var olan bir elemanın bulunduğu index'e ekleme O(n)  
     - Read    : O(n)  
     - Update  : O(1)  
     - Delete  : O(n)  

## Kullanılan Sınıflar ve Yöntemler

- *Sort*: Bubble Sort ve Insertion Sort algoritmalarını içerir.
- *MaxSubArraySum*: Böl ve Fethet algoritması ile maksimum alt dizi toplamını hesaplar.
- *KadeneSubArray*: Kadane algoritmasını kullanarak maksimum alt dizi toplamını hesaplar.
- *Power*: Bir sayının üssünü hesaplar.
- *ArrayLogger*: Dizi verilerini konsola yazdırmak için yardımcı sınıf.

## Zaman Karmaşıklığı

Her algoritma için zaman karmaşıklığı, en iyi durum, ortalama durum ve en kötü durum analizleriyle birlikte belirtilmiştir. Bu analizler, her algoritmanın performansını anlamanıza yardımcı olacaktır.

## Kullanım

1. Projeyi çalıştırarak sırasıyla her algoritmanın nasıl çalıştığını görebilirsiniz.
2. Konsol ekranında, sıralama algoritmalarının sıralamadan önce ve sonra diziyi nasıl değiştirdiği, maksimum alt dizi toplamı hesaplamalarının nasıl yapıldığı gibi örnekler görüntülenir.

## Kurulum

1. *Proje Dosyalarını İndirme*
   - Projeyi bir klasöre indirin veya GitHub'dan klonlayın.

2. *Gerekli Bağımlılıkları Yükleyin*
   - .NET Core veya .NET Framework yüklü olmalıdır.
   - Projeyi Visual Studio veya başka bir C# IDE'si ile açın.

3. *Projeyi Çalıştırın*
   - Visual Studio'da projeyi çalıştırarak konsol uygulamasını açın.
