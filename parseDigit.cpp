#include <iostream>
#include <typeinfo>
#include <string>
#include <stdlib.h>   
using namespace std;

int main() {
    string myin, pre;
    int conv, sum=0;
    
    // int myin;
    cin >> myin;
    // cout << typeid(myin).name() << endl;
    for (int i=0; i<myin.length(); i++)
    {
      cout << myin.at(i) << " ";
      pre = string(1,myin.at(i));
      conv = stoi(pre);
      sum = sum + conv;
    }
    
    cout << sum;
    cout << endl;   
    
    return 0;
}
