﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demos.FuncDemo
{
    public class Progrom
    {
        static void Main()
        {
            Func<int, bool> f1 = IsNumberLessThen5;
            bool flag = f1(4);
            Console.WriteLine(flag);

            //以下是其它的用法，与IsNumberLessThen5作用相同。只是写法不同而已。
            Func<int, bool> f2 = i => i < 5;
            Func<int, bool> f3 = (i) => { return i < 5; };
            Func<int, bool> f4 = delegate (int i) { return i < 5; };
            flag = f2(4); Console.WriteLine(flag);
            flag = f3(4); Console.WriteLine(flag);
            flag = f4(4); Console.WriteLine(flag);
        }

        private static bool IsNumberLessThen5(int number)
        {
            if (number < 5)
                return true;
            return false;
        }
    }
}