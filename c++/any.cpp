#include<iostream>
#include<string>
using namespace std;

int main()
{
    cout << "String to reverse: ";
    string s;
    cin >> s;

    int l = s.length();
    for (int i = 0; i < l / 2; ++i)
    {
        char temp = s[i];
        s[i] = s[l-i-1];
        s[l-i-1] = temp;
    }

    cout << s;
    return 0;
}