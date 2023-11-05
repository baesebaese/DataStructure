using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Array
{
    public static class CircularArray
    {
        // index = (index + 1) % a.Length
        public static void printArray()
        {
            //원형탁자에 8명의 사람이 있다고 가정.
            // a, b, c, d, e, f, g, h
            // 이 때 임의의 사람을 선택해서 그 사람으로부터 시계방향으로 모든 사람들의 명칭을 순서대로 출력하는 프로그램      
            char[] a = "abcdefg".ToCharArray();
            int startIndex = 2;

            for (int i = 0; i < a.Length; i++) {
                int index = (startIndex + i) % a.Length;
                Console.WriteLine(a[index]);
            }

        }
    }
}
