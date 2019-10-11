﻿namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList : List<string>
    {
        private Random random;

        public string RandomString()
        {
            int index = random.Next(0, this.Count - 1);
            string element = this[index];
            this.RemoveAt(index);
            return element;
        }
    }
}
