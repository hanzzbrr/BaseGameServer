using System;
using Backend.Connection;

namespace Backend
{
    class Program
    {
        private static GlobalUpdate _globalUpdate;

        static void Main(string[] args)
        {
            // ServerConnectionManager manager = new ();
            // Console.WriteLine("Hello World!");

            _globalUpdate = new GlobalUpdate(); 
        }
    }
}
