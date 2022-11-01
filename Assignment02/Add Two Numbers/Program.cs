//Leet Code

using Add_Two_Numbers;
using System.Diagnostics.CodeAnalysis;

ListNode l1 = new ListNode(1);

ListNode pointer1 = l1;

for (int j = 0; j< 29; j++)
{
    ListNode l = new ListNode(0);
    pointer1.next = l;
    pointer1 = pointer1.next;
}
pointer1.next = new ListNode(1);

ListNode l2 = new ListNode(5);
//ListNode pointer2 = l2;
//for (int j = 0; j < 3; j++)
//{
//    ListNode l = new ListNode(j);
//    pointer2.next = l;
//    pointer2 = pointer2.next;
//}
ListNode l3 = new ListNode(6);
ListNode l4 = new ListNode(4);

ListNode result = AddTwoNumbers2(l1, l2);

while (result != null)
{
    Console.Write(result.val);
    result = result.next;
}

ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    string num1 = "";
    string num2 = "";

 
    
    while (l1 != null)
    {
        num1 += l1.val;
        l1 = l1.next;
    }
    while (l2 != null)
    {
        num2 += l2.val;
        l2 = l2.next;
    }

    num1 = Reverse(num1);
    num2 = Reverse(num2);

    double sum = Convert.ToDouble(num1) + Convert.ToDouble(num2);

    string sumString = sum.ToString("F99").TrimEnd('0');

    ListNode result = new ListNode(Convert.ToInt32(sumString[sumString.Length -2].ToString()));
    ListNode pointer = result;
    for (int i = (sumString.Length - 3); i>=0; i--)
    {
        pointer.next = new ListNode(Convert.ToInt32(sumString[i].ToString()));
        pointer = pointer.next;
    }

    return result;

}

ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
{
    ListNode dummyHead = new ListNode(0);

    ListNode pointer = dummyHead;

    int carry = 0;

    while (l1 != null || l2 != null || carry != 0)
    {
        int sum = 0;

        if (l1 != null)
        {
            sum += l1.val;
            l1 = l1.next;
        }
        if (l2 != null)
        {
            sum += l2.val;
            l2 = l2.next;
        }

        sum += carry;

        carry = sum / 10;

        pointer.next = new ListNode(sum % 10);
        pointer = pointer.next;
    }


    return dummyHead.next;
}

//{
//    int x = (l1 != null) ? l1.val : 0;
//    int y = (l2 != null) ? l2.val : 0;
//    int sum = carry + x + y;
//    carry = sum / 10;
//    pointer.next = new ListNode(sum % 10);
//    pointer = pointer.next;
//    if (l1 != null) l1 = l1.next;
//    if (l2 != null) l2 = l2.next;
//}


string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}