﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Dog
    {
        public string Name { get; set; }

        // Add bark() method
        public void bark ()
        {
            Console.WriteLine("{0} is barking...", Name);
        }



        // Add doTrick() method
        public void doTrick (string trickName)
        {
            Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}", Name, trickName);
        }

    }
}
