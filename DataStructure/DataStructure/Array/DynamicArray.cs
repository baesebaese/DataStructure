using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Array
{
    public static class DynamicArray
    {
        private static object[] arr = new object[0];

        public static void Add(object element) 
        {
            // 기존 배열 크기보다 1이 더 큰 임시 배열 생성
            var temp = new object[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++) 
            {
                // 임시 배열에 요소 복사
                temp[i] = arr[i];
            }

            // 임시 배열을 기존 배열에 할당
            arr = temp;

            // 배열 마지막 인덱스에 새 배열요소 추가
            arr[arr.Length - 1] = element;        
        }

    }
}
