//LeetCode

string address = "255.100.50.0";
string defangedAddress = DefangIPaddr(address);
Console.WriteLine(defangedAddress);
string DefangIPaddr(string address)
{
   string ans = "";
    for (int i = 0; i < address.Length; i++)
    {
        if (address[i] == '.')
        {
            ans += "[.]";
        }
        else
        {
            ans += address[i];
        }
    }
    return ans;
}