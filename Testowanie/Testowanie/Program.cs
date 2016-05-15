using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testowanie
{
    public class Program
    {
        public static void QuickSort(int[] tab, int s, int p)
        {
            int i = p;
            int j = s;
            int pivot = tab[s];
            while (i < j)
            {
                while (tab[i] < pivot) i++;
                while (tab[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = temp;
                    i++;
                    j--;

                }
            }
            if (p < j) QuickSort(tab, p, j);
            if (i < s) QuickSort(tab, i, s);

        }
        static void Main(string[] args)
        {
        }
    }
}
