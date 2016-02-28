using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameFramework.Board
{
    internal class Tile
    {
        private LinkedList<Unit> units;

        public Tile()
        {
            units = new LinkedList<Unit>();
        }

        public void addUnit (Unit unit)
        {
            units.AddLast(unit);
        }

        public void removeUnit (Unit unit)
        {
            units.Remove(unit);
        }

        public LinkedList<Unit> getUnits()
        {
            return units;
        }

        public void removeUnits()
        {
            var node = units.First;
            while(node != null)
            {
                var next = node.Next;
                units.Remove(node);
                node = next;
            }
        }
    }
}
