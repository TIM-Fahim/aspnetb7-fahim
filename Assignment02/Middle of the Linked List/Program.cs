// LeetCode

using Middle_of_the_Linked_List;
using System.Collections;

ListNode MiddleNodeArray(ListNode head)
{
    List<ListNode> arrayList = new List<ListNode>();

    int length = 0;
    while (head != null)
    {
        arrayList.Add(head);
        head = head.next;
        length++;
    }

    return arrayList[length / 2];
}

ListNode MiddleNode(ListNode head)
{
    ListNode middle = head;
    ListNode end = head;


    while (end != null && end.next != null)
    {
        middle = middle.next;
        end = end.next.next;
    }
    return middle;
}

