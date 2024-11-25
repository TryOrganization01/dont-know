﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Program
    {
    public delegate string GreetingsDelegate(string name);
        static void Main(string[] args)
        {
            for(int i=0;i<10;i++) {
                Console.WriteLine(i);
            }
            GreetingsDelegate obj = (name) =>
            {
                return "Hello @" + name + " Welcome";
            };
            string GreetingsMessage = obj.Invoke("Sumedh");
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }
        //public static string Greetings(string name)
        //{
        //    return "Hello @" + name + " Wlcome";
        //}
    }
}
