using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class ShoppingCart
    {
        public List<string> stringList { get; set; }
    }

    public static class MyExtensionMethod
    {
        public static decimal TotalLength(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (string s in cartParam)
            {
                total += s.Length;
            }
            return total;
        }
    }
}