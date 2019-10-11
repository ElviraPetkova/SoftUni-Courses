﻿namespace Telephony
{
    using System;
    using System.Linq;

    public class Smartphone : ICaller, IBrowser
    {
        public string Browse(string url)
        {
            if (url.Any(Char.IsDigit))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (!number.All(Char.IsDigit))
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }
    }
}