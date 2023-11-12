using DataStructure.Linked_List;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            Console.WriteLine("Hello");

            /*연결 리스트*/
            var list = new SinglyLinkedList<int>();

            // 리스트에 요소 추가
            for (int i = 0; i < 5; i++) {
                list.Add(new SinglyLinkedListNode<int>(i));
            }

            //index가 2인 요소 삭제
            var node = list.GetNode(2);
            list.Remove(node);

            // index가 1인 요소 가져오기
            node = list.GetNode(1);

            //index 1인 요소 뒤에 99 삽입
            list.AddAfter(node, new SinglyLinkedListNode<int>(99));

            //리스트 카운트
            int cnt = list.Count();

            //리스트 출력
            for (int i = 0; i < cnt; i++) {
                var n = list.GetNode(i);
                Console.WriteLine(n.Data);
            }

        } 
    }

}