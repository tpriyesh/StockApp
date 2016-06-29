﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock.Utilities
{
    public static class RandomStringGenerator
    {
        private static readonly Random Random = new Random((int)DateTime.Now.Ticks);

        public static string RandomString()
        {
            return RandomString(32);
        }

        public static string RandomString(int size)
        {
            var builder = new StringBuilder();
            for (var i = 0; i < size; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * Random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
