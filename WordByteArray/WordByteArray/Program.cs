using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordByteArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ByteArray bytA = new ByteArray(4);
            bytA.Put(0, 1);
            bytA.Put(1, 0);
            bytA.Put(2, 0);
            bytA.Put(3, 1);

            foreach (int n in bytA.Self) Console.Write(n);

            Console.WriteLine();

            WordArray wordA = new WordArray(4);
            wordA.Put(0, "apple");
            wordA.Put(1, "banana");
            wordA.Put(2, "pear");
            wordA.Put(3, "mango");

            foreach (string w in wordA.Self) Console.Write(w + " ");

            Console.ReadKey();
        }
    }

    public class ByteArray
    {
        //local private variables
        private int _arraySize;
        private int[] _self;

        //properties
        public int ArraySize
        {
            get { return _arraySize; }
            set { _arraySize = value; }
        }

        public int[] Self
        {
            get { return _self; }
            set { _self = value; }
        }

        //constructor
        public ByteArray(int arraySize)
        {
            _self = new int[arraySize];
            _arraySize = arraySize;
        }

        //Methods
        public void Put(int n, int value)
        {
            _self[n] = value;
        }
        public int Get(int n)
        {
            return _self[n];
        }

    }

    public class WordArray
    {
        //local private variables
        private int _arraySize;
        private string[] _self;

        //properties
        public int ArraySize
        {
            get { return _arraySize; }
            set { _arraySize = value; }
        }
        public string[] Self
        {
            get { return _self; }
            set { _self = value; }
        }

        //constructor
        public WordArray(int arraySize)
        {
            _self = new string[arraySize];
            _arraySize = arraySize;
        }

        //Methods
        public void Put(int n, string value)
        {
            _self[n] = value;
        }
        public string Get(int n)
        {
            return _self[n];
        }
    }
}
