//Leet Code

using System.Collections;
using System.Linq;

int maxDepth(string s)
{
    int count = 0;
    Stack st = new Stack();

    for (int i = 0; i < s.Length; i++)
    {

        if (s[i] == '<')
        {
            st.Push(i);//pushing the bracket in the stack
        }
        else
        {
            if (s[i] == '>')
            {
                if (count < st.Count)
                {

                    count = st.Count;
                }
                /*keeping track of the parenthesis and storing it before removing
                it when it gets balanced*/
                st.Pop();
            }
        }

    }
    return count;
}