using System;

namespace Furniture
{
    public class Lamp : Furniture, IComparable<Lamp>
    {
        public double Current { get; set; }

        public override string ToString()
        {
            return $"Lampan {Name} drar {Current} amp";
        }

        public int CompareTo(Lamp other)
        {
            return Current.CompareTo(other.Current);
        }
    }
}