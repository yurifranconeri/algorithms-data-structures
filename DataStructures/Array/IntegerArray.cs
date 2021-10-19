using System;

namespace Array
{
    public class IntegerArray
    {
        public int[] Array { get; }

        private int Index = 0;

        private int Capacity = 8;

        public IntegerArray()
        {
            Array = new int[Capacity];
        }

        public IntegerArray(int capacity)
        {
            Capacity = capacity;
            Array = new int[Capacity];
        }

        public void Add(int value)
        {
            Array[Index] = value;
            Index++;
        }


        public void Remove()
        {
            Array[Index] = '\0';
            Index--;
        }

        public int Size()
        {
            return Index;
        }

        public bool IsEmpty()
        {
            return Array[0] == '\0';
        }
        public override string ToString()
        {
            return $"[{string.Join(",", Array)}]";
        }


    }
}
