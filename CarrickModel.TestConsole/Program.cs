using System;

namespace ScoutModel.TestConsole
{
    class Program
    {
        static DotNetController _controller;

        static void Main(string[] args)
        {
            _controller = new DotNetController("https://localhost:44300", "chris@noonanfamily.org", "Test123!");
            _controller.Execute();

            _controller.readdata();

 
            Console.ReadKey();
        }
    }
}
