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
        
    
}


