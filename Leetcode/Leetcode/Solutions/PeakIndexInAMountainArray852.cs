using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions;

public class PeakIndexInAMountainArray852
{
    public static int PeakIndexInMountainArray(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

            if (arr[middle] > arr[middle + 1] && arr[middle] > arr[middle - 1])
                return middle;
            if (arr[middle] > arr[middle - 1] && arr[middle] < arr[middle + 1])
                left = middle;
            if (arr[middle] < arr[middle - 1] && arr[middle] > arr[middle + 1])
                right = middle;
        }

        return -1;
    }
}