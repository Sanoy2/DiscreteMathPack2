using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathPack2Tests
{
    public static class ArrayComparer
    {
        public static bool Compare(int[] correctArray, int[] toCheckArray)
        {
            if (correctArray.Length != toCheckArray.Length)
            {
                return false;
            }

            for (int i = 0; i < correctArray.Length; i++)
            {
                if (correctArray[i] != toCheckArray[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
