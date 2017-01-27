using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Cell
            {
                Value = 9,
                Next = null
            };

            var b = new Cell
            {
                Value = 47,
                Next = a
            };

            var c = new Cell
            {
                Value = 72,
                Next = b
            };

            var d = new Cell
            {
                Value = 31,
                Next = c
            };

            var e = new Cell
            {
                Next = d
            };

            Iterate(e);
            //Console.WriteLine("Found: "+FindCellBefore(d,47).Value);
            //AddAttBegining(e, new Cell { Value = 555 });
            //AddAttEndCell(e, new Cell { Value = 555 });
            var e_copy = InsertionSort(e);
            Iterate(e_copy);
            Console.ReadLine();
        }

        static void Iterate(Cell top)
        {
            top = top.Next;
            while (top != null)
            {
                Console.Write(top.Value + " ");
                top = top.Next;
            }
            Console.WriteLine();
        }

        static void AddAttBegining(Cell top, Cell new_sell)
        {
            new_sell.Next = top.Next;
            top.Next = new_sell;
        }

        static void AddAttEndCell(Cell top, Cell new_sell)
        {
            while (top.Next != null)
            {
                top = top.Next;
            }
            top.Next = new_sell;
            new_sell.Next = null;
        }

        static Cell FindCellBefore(Cell top, int target)
        {
            if (top == null)
                return null;
            while (top.Next != null)
            {
                if (top.Next.Value == target)
                    return top;
                top = top.Next;
            }
            return null;
        }

        static Cell CopyList(Cell old_santinel)
        {
            Cell new_santinel = new Cell();
            Cell last_added = new_santinel;
            Cell old_cell = old_santinel.Next;
            while (old_cell != null)
            {
                last_added.Next = new Cell();
                last_added = last_added.Next;
                last_added.Value = old_cell.Value;
                old_cell = old_cell.Next;
            }

            last_added.Next = null;
            return new_santinel;
        }

        static Cell InsertionSort(Cell input)
        {
            Cell senitell = new Cell();
            senitell.Next = null;
            input = input.Next;
            while (input != null)
            {
                Cell next_cell = input;
                input = input.Next;

                Cell after_me = senitell;
                while(after_me.Next!=null && after_me.Next.Value < next_cell.Value)
                {
                    after_me = after_me.Next;
                }
                next_cell.Next = after_me.Next;
                after_me.Next = next_cell;
            }

            return senitell;
        }

       /* static Cell SelectionSort(Cell input)
        {
            Cell senitell = new Cell();
            senitell.Next = null;

        }*/
    }



    public class Cell
    {
        public int? Value;
        public Cell Next;
    }
}
