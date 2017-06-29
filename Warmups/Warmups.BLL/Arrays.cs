using System;

namespace Warmups.BLL
{
    public class Arrays
    {
        public bool FirstLast6(int[] numbers)
        {
            if (numbers[0] == 6 || numbers[numbers.Length - 1] == 6)
                return true;
            return false;
        }

        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length > 0 && numbers[0] == numbers[numbers.Length - 1])
                return true;
            return false;
        }

        public int[] MakePi(int n)
        {
            var pi = Math.PI;
            var result = new int[n];
            for (var i = 0; i < n; i++)
            {
                result[i] = (int) Math.Floor(pi);
                pi -= result[i];
                pi *= 10;
            }
            return result;
        }

        public bool CommonEnd(int[] a, int[] b)
        {
            return a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1];
        }

        public int Sum(int[] numbers)
        {
            return numbers[0] + numbers[1] + numbers[2];
        }

        public int[] RotateLeft(int[] numbers)
        {
            int[] rotated = {numbers[1], numbers[2], numbers[0]};
            return rotated;
        }

        public int[] Reverse(int[] numbers)
        {
            var newArray = new int[numbers.Length];
            var a = 0;
            for (var i = numbers.Length - 1; i >= 0; i--)
            {
                newArray[a] = numbers[i];
                a++;
            }
            return newArray;
        }

        public int[] HigherWins(int[] numbers)
        {
            if (numbers[0] > numbers[numbers.Length - 1])
                for (var i = 1; i < numbers.Length; i++)
                    numbers[i] = numbers[0];
            else
                for (var i = 0; i < numbers.Length - 1; i++)
                    numbers[i] = numbers[numbers.Length - 1];
            return numbers;
        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] mid = {a[1], b[1]};
            return mid;
        }

        public bool HasEven(int[] numbers)
        {
            var i = 0;
            foreach (var num in numbers)
            {
                i++;
                if (num % 2 == 0)
                    return true;
            }
            return false;
        }

        public int[] KeepLast(int[] numbers)
        {
            var num = new int[numbers.Length * 2];
            num[numbers.Length * 2 - 1] = numbers[numbers.Length - 1];
            return num;
        }

        public bool Double23(int[] numbers)
        {
            var count2 = 0;
            var count3 = 0;
            for (var i = 0; i < numbers.Length; i++)
                if (numbers[i] == 2)
                    count2 += 1;
                else if (numbers[i] == 3)
                    count3 += 1;
            if (count2 == 2 || count3 == 2)
                return true;
            return false;
        }

        public int[] Fix23(int[] numbers)
        {
            if (numbers[0] == 2 && numbers[1] == 3)
            {
                numbers[1] = 0;
                return numbers;
            }
            if (numbers[1] == 2 && numbers[2] == 3)
            {
                numbers[2] = 0;
                return numbers;
            }
            return numbers;
        }

        public bool Unlucky1(int[] numbers)
        {
            if (numbers.Length == 0 || numbers.Length == 1)
                return false;
            if (numbers[0] == 1 && numbers[1] == 3 || numbers[1] == 1 && numbers[2] == 3 ||
                numbers[numbers.Length - 1] == 3 && numbers[numbers.Length - 2] == 1)
                return true;
            return false;
        }

        public int[] Make2(int[] a, int[] b)
        {
            var myArray = new int[2];
            var alen = a.Length;
            var blen = b.Length;

            if (alen == 0)
            {
                myArray[0] = b[0];
                myArray[1] = b[1];
                return myArray;
            }
            if (alen == 1 && blen == 1)
            {
                myArray[0] = a[0];
                myArray[1] = b[0];
                return myArray;
            }
            if (alen == 1)
            {
                myArray[0] = a[0];
                myArray[1] = b[0];
                return myArray;
            }
            myArray[0] = a[0];
            myArray[1] = a[1];
            return myArray;
        }
    }
}