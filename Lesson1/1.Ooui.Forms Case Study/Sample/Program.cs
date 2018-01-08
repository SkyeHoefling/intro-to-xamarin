using System;
using Ooui;
using Xamarin.Forms;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Xamarin.Forms.Forms.Init();
            MainPage.Publish();
            
            Console.WriteLine("Hit any key to close program");
            Console.ReadLine();
        }
    }
}
