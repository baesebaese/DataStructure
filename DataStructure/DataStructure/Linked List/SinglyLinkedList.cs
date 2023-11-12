using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Linked_List
{
    // 연결 리스트의 노드 클래스
    public class SinglyLinkedListNode<T>
    {
        public T Data { get; set; }
        
        public SinglyLinkedListNode<T> Next { get; set; }

        public SinglyLinkedListNode(T data) {
            this.Data = data;
            this.Next = null;
        }

    }

    public class SinglyLinkedList<T> {
        // head를 사용하여 전체 리스트를 순차적으로 엑세스
        private SinglyLinkedListNode<T> head;

        public void Add(SinglyLinkedListNode<T> newNode) {
            if (head == null) { //리스트가 비어 있으면
                head = newNode;
            }
            else { //리스트가 비어 있지 않으면
                var current = head;
                while (current != null && current.Next != null) {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void AddAfter(SinglyLinkedListNode<T> current, SinglyLinkedListNode<T> newNode) {
            if (head == null || current == null || newNode == null) {
                throw new InvalidOperationException();
            }

            newNode.Next = current.Next;
            current.Next = newNode;

        }

        public void Remove(SinglyLinkedListNode<T> removeNode) {
            if (head == null || removeNode == null) {
                return;
            }

            //삭제할 노드가 첫 노드일 경우
            if (removeNode == head) {
                head = head.Next;
                removeNode = null;
            }
            else { // 첫 노드가 아닐 경우 해당 노드를 검색하여 삭제
                var current = head;

                //삭제할 노드의 바로 이전 노드를 검색
                while (current != null && current.Next != removeNode) {
                    current = current.Next;
                }

                if (current != null) {
                    //이전 노드의 Next에 삭제노드의 Next를 할당
                    current.Next = removeNode.Next;
                    removeNode = null;
                }
            }
        }

        // 특정 위치 인덱스에 있는 노드를 리턴
        // 인덱스가 연결리스트를 벗어나면 null 리턴
        // O(n)의 검색시간을 갖는다.
        public SinglyLinkedListNode<T> GetNode(int index) { 
            var current = head;
            for (int i = 0; i < index && current != null; i++) {
                current = current.Next;
            }

            //index가 리스트 카운트보다 크면 리턴
            return current;
        }

        public int Count() {
            int cnt = 0;

            var current = head;
            while (current != null) {
                cnt++;
                current = current.Next;
            }

            return cnt;
        }
    }
}
