using System;

namespace Warmups.BLL
{
    public class Conditionals
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            return aSmile == bSmile;
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            var sleepIn = true;

            if (isWeekday)
                if (isVacation)
                    sleepIn = true;
                else
                    sleepIn = false;
            else
                sleepIn = true;
            return sleepIn;
        }

        public int SumDouble(int a, int b)
        {
            int sum;

            if (a != b)
                sum = a + b;
            else
                sum = (a + b) * 2;
            return sum;
        }

        public int Diff21(int n)
        {
            var m = 21;

            {
                if (m < n)
                    return (n - m) * 2;
                if (n < m)
                    return m - n;
                if (n == m)
                    return 0;
            }
            return 0;
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (hour < 7 || hour > 20)
            {
                if (isTalking)
                    return true;
                return false;
            }
            return false;
        }

        public bool Makes10(int a, int b)
        {
            if (a == 10)
                return true;
            if (b == 10)
                return true;
            if (a + b == 10)
                return true;
            return false;
        }

        public bool NearHundred(int n)
        {
            {
                if (n >= 90 || n >= 110)
                    return true;
                if (n >= 190 || n >= 210)
                    return true;
                if (n <= 89 || n >= 211)
                    return false;
            }
            return false;
        }

        public bool PosNeg(int a, int b, bool negative)
        {
            if (negative)
                return a < 0 && b < 0;
            return a * b < 0;
        }

        public string NotString(string s)
        {
            if (s.StartsWith("not"))
                return s;
            return "not " + s;
        }

        public string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }

        public string FrontBack(string str)
        {
            if (str.Length <= 1)
                return str;
            var a = str.Substring(0, 1);
            var b = str.Substring(1, str.Length - 1 - 1);
            var c = str.Substring(str.Length - 1);
            {
                return c + b + a;
            }
        }

        public string Front3(string str)
        {
            if (str.Length <= 3)
                return str + str + str;
            var newString = str.Substring(0, 3);
            {
                return newString + newString + newString;
            }
        }

        public string BackAround(string str)
        {
            var last = str[str.Length - 1];
            return last + str + last;
        }

        public bool Multiple3or5(int number)
        {
            return number % 3 == 0 || number % 5 == 0;
        }

        public bool StartHi(string str)
        {
            if (str.Length == 2)
                return true;
            if (str.Length < 2)
                return false;
            if (str.Substring(0, 3) == "hi " || str.Substring(0, 3) == "hi,")
                return true;

            return false;
        }

        public bool IcyHot(int temp1, int temp2)
        {
            return temp1 < 0 && temp2 > 100 || temp1 > 100 && temp2 < 0;
        }

        public bool Between10and20(int a, int b)
        {
            if (a >= 10 && a <= 20 || b >= 10 && b <= 20)
                return true;
            return false;
        }

        public bool HasTeen(int a, int b, int c)
        {
            return a >= 13 && a <= 19 || b >= 13 && b <= 19 || c >= 13 && c <= 19;
        }

        public bool SoAlone(int a, int b)
        {
            if (a >= 13 && a <= 19 && b >= 13 && b <= 19)
                return false;
            if (a >= 13 && a <= 19 || b >= 13 && b <= 19)
                return true;
            return false;
        }

        public string RemoveDel(string str)
        {
            if (str.Length >= 4 && str.Substring(1, 3).Equals("del"))
                return str.Substring(0, 1) + str.Substring(4);
            return str;
        }

        public bool IxStart(string str)
        {
            if (str.Substring(1, 2).Equals("ix"))
                return true;
            return false;
        }

        public string StartOz(string str)
        {
            var result = "";

            if (str.Length >= 1 && str[0] == 'o')
                result = result + str[0];

            if (str.Length >= 2 && str[1] == 'z')
                result = result + str[1];
            {
                return result;
            }
        }

        public int Max(int a, int b, int c)
        {
            var max = a;

            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;
        }

        public int Closer(int a, int b)

        {
            var int1 = Math.Abs(a - 10);
            var int2 = Math.Abs(b - 10);

            if (int1 == int2)
                return 0;
            if (int1 > int2)
                return b;
            return a;
        }

        public bool GotE(string str)
        {
            var len = str.Length;
            var counter = 0;

            for (var i = 0; i < len; i++)
                if (str[i] == 'e')
                    counter++;

            if (counter >= 1 && counter <= 3)
                return true;
            return false;
        }

        public string EndUp(string str)
        {
            var len = str.Length;

            if (len <= 3)
            {
                return str.ToUpper();
            }
            var str2 = str.Substring(len - 3, len - (len - 3));
            return str.Substring(0, len - 3) + str2.ToUpper();
        }

        public string EveryNth(string str, int n)
        {
            var str2 = "";
            for (var i = 0; i < str.Length; i = i + n)
                str2 += str[i];
            return str2;
        }
    }
}