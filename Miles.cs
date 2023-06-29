using System;

namespace RunWithMe
{
    public class Miles<T>
    { 
        public T data;

        public Miles(T data)
        {
            this.data = data;
            Console.WriteLine("Data passed: " + this.data);
        }
    }

    class Program
    {
        static void Main()
        { 
           Miles<int> milesran = new Miles<int>(23);
        }
    }
}


