using System;

namespace Furniture
{
    public class Table : Furniture, IComparable<Table>
    {
        public double AreaOfTable { get; set; }

        public override string ToString()
        {
            return $"Bordet {Name} har ytan {AreaOfTable}";
        }

        public int CompareTo(Table other)
        {
            return AreaOfTable.CompareTo(other.AreaOfTable);
        }
    }
}