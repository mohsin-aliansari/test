﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is first project");

            Animal a = new Animal();
            a.show();

            a =  new Dog();
            a.show();



        }
    }


    class Animal
    {
        public  virtual void show()
        {
            Console.WriteLine("In Show of Animal Class");
            
        }
      dd

    }
    
    class Dog : Animal
    {
        public  override void show()
        {
            Console.WriteLine("In show of Dog");
        }
    }
}

