#include<iostream>
#include<string>
using namespace std;

int main()
{
    cout << "String to reverse: ";
    string s;
    cin >> s;
    int i = s.length() - 1;
    while(i >= 0) { cout << s[i--]; }
}
