using System;
using System.Collections;
using System.Data;
using System.Xml.Schema;

namespace Core
{
    public class Sodoku : ISodoku
    {
        public int Generate()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }
        public void Print(ArrayList arrayList)
        {
            foreach (ArrayList item in arrayList)
            {
                int count = 1;
                foreach (var number in item)
                {
                    if (count < 3)
                    {
                        Console.Write(number);
                        count++;
                        continue;
                    }
                    Console.WriteLine(number);
                    count = 1;
                }
            }
        }

        public ArrayList Set(int n, ArrayList arrayList)
        {

            if (n == 1)
            {
                return arrayList;
            }

            ArrayList arrayListResult = new ArrayList();

            while (arrayListResult.Count < 9)
            {
                int number = Generate();

                if (!arrayListResult.Contains(number))
                    arrayListResult.Add(number);
            }

            arrayList.Add(arrayListResult);

            //IComparer comparer = new ArrayListComparer(); 
            //arrayListResult.Sort(comparer);

            return Set(--n, arrayList);
        }
    }


    public class ArrayListComparer : IComparer
    {
        int IComparer.Compare(Object x, Object y)
        {
            return ((new CaseInsensitiveComparer()).Compare(y, x));
        }
    }

}

