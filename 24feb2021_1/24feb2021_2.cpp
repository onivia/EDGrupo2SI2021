#include <iostream>
using namespace std;

void f1(int a) {
    a=a+1;
}
void f2(int b[]) {
    b[0]=b[0]+1;
}

int main() {
    int num=10;
    int x[1]={10};

    f1(num);
    cout<<num<<endl; //Neyder: 11

    f2(x);
    cout<<x[0]<<endl; //Nicolas: 11

    return 0;
}
