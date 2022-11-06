// LeetCode
using Merge_Two_Sorted_Lists;

ListNode l10 = new ListNode(1);
ListNode l11 = new ListNode(2);
l10.next = l11;
ListNode l12 = new ListNode(4);
l11.next = l12;

ListNode l20 = new ListNode(1);
ListNode l21 = new ListNode(3);
l20.next = l21;
ListNode l22 = new ListNode(4);
l21.next = l22;

ListNode l3 = MergeTwoLists(l10, l20);

while (l3 != null)
{
    Console.WriteLine(l3.val);
    l3 = l3.next;
}

ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    if (list1 == null || list2 == null)
    {
        if (list1 == null)
        {
            return list2;
        }
        else
        {
            return list1;
        }
    }
    ListNode dummyHead = new ListNode(0);
    ListNode current = dummyHead;

    while (list1 != null && list2 != null)
    {
        if (list1.val <= list2.val)
        {
            current.next = list1;
            list1 = list1.next;
        }
        else
        {
            current.next = list2;
            list2 = list2.next;
        }
        current = current.next;
    }
    if (list1 != null)
    {
        current.next = list1;
    }
    if (list2 != null)
    {
        current.next = list2;
    }

    return dummyHead.next;
}