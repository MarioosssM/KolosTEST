using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testowanie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testowanie.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void QuickSortTest()
        {
            int[] tab = new int[] { 3, 1, 2, 5, 4, 6 };
            Program.QuickSort(tab, 0, tab.Length - 1);
            for (int i = 0; i < tab.Length - 1; i++)
            {
                Assert.IsTrue(tab[i] <= tab[i + 1]);

            }
        }
    }
}