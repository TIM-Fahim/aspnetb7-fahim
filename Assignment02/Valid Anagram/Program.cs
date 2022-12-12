bool IsAnagram(string s, string t)
{
    var first = s.OrderBy(c => c);
    var second = t.OrderBy(c => c);
    return first.SequenceEqual(second);
}

bool IsAnagram2(string s, string t)
{
    string first = String.Concat(s.OrderBy(c => c));
    //Console.WriteLine(first);
    //Contact replace string
    string second = String.Concat(t.OrderBy(c => c));

    return first == second;
}

IsAnagram2("anagram", "nagaram");

//string f = "fahim";
//string g = "sahryer";

//string first = String.Concat(g);
//Console.WriteLine(first);