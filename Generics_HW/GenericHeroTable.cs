using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HW
{
    internal class GenericHerosTable<T> where T : Heros
    {
       T[] knightTables;
        private int NumberOfKnights { get; set; }

        public GenericHerosTable()
        {
            knightTables = new T[3];
        }

        public void Set(int index, T newKnight)
        {
            if (knightTables[index] == null)
                knightTables[index] = newKnight;
            else
                Console.WriteLine("The index is not empty...");
        }
        public void Delete(int index)
        {
            knightTables[index] = null;
        }
        public int GetKnightNumber()
        {

            for (int i = 0; i < knightTables.Length; i++)
            {
                if (knightTables[i] != null)
                {
                    NumberOfKnights++;
                }

            }
            return NumberOfKnights;
        }
        public T[] GetKnightArray()
        {

            T[] myKnight = new T[GetKnightNumber()];
            for (int i = 0; i < knightTables.Length; i++)
            {
                int z = 0;


                if (knightTables[i] != null)
                {
                    myKnight[i - z] = knightTables[i];

                }
                else
                {
                    z++;
                    continue;
                }

            }
            return myKnight;




        }

        public string this[int index]
        {
            get
            {
                while (index > knightTables.Length-1)
                {
                    index = index - knightTables.Length-1;

                }
                return CheakingIndexer(index);



            }
            set
            {

            }
        }

        public string CheakingIndexer(int index)
        {
            if (knightTables == null)
                return null;
            if (index >= 0 && index <= knightTables.Length-1 && knightTables[index] != null)
                return knightTables[index].Id.ToString();
            if (index >= 0 && index <= knightTables.Length-1 && knightTables[index] == null)
            {
                int currentValueMax = 0;
                int currentValueMin = 0;
                int max = knightTables.Length-1;
                int min = 0;
                for (int i = knightTables.Length-1; i <= index; i--)
                {
                    if (knightTables[i] != null && i != index)
                    {
                        currentValueMax = max - i;
                    }

                }
                for (int j = 0; j <= index; j++)
                {

                    if (knightTables[j] != null && j != index)
                    {
                        currentValueMin = j - min;
                    }
                }
                if (currentValueMax < currentValueMin)
                    return knightTables[currentValueMax].Id.ToString();
                if (currentValueMin < currentValueMax)
                    return knightTables[currentValueMin].Id.ToString();
            }
            return "";


        }

    }
}
