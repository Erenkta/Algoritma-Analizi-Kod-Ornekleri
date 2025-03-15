using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Analizi.Hafta_2
{
    public class MaxSubArraySum
    {

        public int MaxSubarraySum(int[] arr)
        {
            return Helper(arr, 0, arr.Length - 1);
        }
        public int Helper(int[] arr, int low, int high)
        {
            if (low == high)
                return arr[low];

            int mid = (low + high) / 2;

            // Sol, sağ ve ortadan geçen maksimumları bul
            int leftMax = Helper(arr, low, mid);
            int rightMax = Helper(arr, mid + 1, high);
            int crossMax = MaxCrossingSum(arr, low, mid, high);

            return Math.Max(leftMax, Math.Max(rightMax, crossMax));
        }
        public int MaxCrossingSum(int[] arr, int low, int mid, int high)
        {
            // Orta noktadan sola doğru maksimum toplam
            int leftSum = int.MinValue;
            int total = 0;
            for (int i = mid; i >= low; i--)
            {
                total += arr[i];
                if (total > leftSum)
                    leftSum = total;
            }

            // Orta noktadan sağa doğru maksimum toplam
            int rightSum = int.MinValue;
            total = 0;
            for (int i = mid + 1; i <= high; i++)
            {
                total += arr[i];
                if (total > rightSum)
                    rightSum = total;
            }

            return leftSum + rightSum;
        }
    }
}
