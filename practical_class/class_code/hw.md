hw1

寫法一
```c++
#include <iostream>
#include <cstdlib>

using namespace std;

void generate(int n){
    for(int i = 0; i < n; i++){
        for(int j = 0; j <= i; j++){
            cout << '*';
        }
        for(int k = n - 1; k > i; k--){
            cout << '-';
        }
        cout << endl;
    }    
}

int main(){
    int a = 3;
    int b = 4;
    int c = 5;

    cout << "result1: " << endl;
    generate(a);
    cout << "\nresult2: " << endl;
    generate(b);
    cout << "\nresult3 : " << endl;
    generate(c);

    return 0;
}
```

寫法二
```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
    int a, b, c;
    cout << "input1: ";
    cin >> a;
    cout << "input2: ";
    cin >> b;
    cout << "input3: ";
    cin >> c;
    cout << "\nresult1:" << endl; 
    for(int i = 0; i < a; i++){
        for(int j = 0; j <= i; j++){
            cout << '*';
        }
        for(int k = a - 1; k > i; k--){
            cout << '-';
        }
        cout << endl;
    }
    
    cout << "\nresult2: " << endl;
    for(int i = 0; i < b; i++){
        for(int j = 0; j <= i; j++){
            cout << '*';
        }
        for(int k = b - 1; k > i; k--){
            cout << '-';
        }
        cout << endl;
    }
    
    cout << "\nresult3: " << endl;
    for(int i = 0; i < c; i++){
        for(int j = 0; j <= i; j++){
            cout << '*';
        }
        for(int k = c - 1; k > i; k--){
            cout << '-';
        }
        cout << endl;
    } 

    return 0;
}
```

寫法三(不完全相同)
```c++
#include <iostream>
#include <cstdlib>
using namespace std;

int generate(int n){
	string a="";
	for(int i = 0; i < n; i++){
		a += "*";
	}

	string b = " ";
	for(int i = 0; i <= n; i++){
		cout << a << b << endl;
		b += "\b\b-";
	}
}

int main(){
	// to generate a '*' tree in O(n);

	int a, b, c;
	cout << "input1: ";
	cin >> a;
	cout << "input2: ";
	cin >> b;
	cout << "input3: ";
	cin >> c;

	cout << endl << "result1:" << endl;
	generate(a);
	cout << endl << "result2:" << endl;
	generate(b);
	cout << endl << "result3:" << endl;
	generate(c);

	return 0;
}
```

teacher hw1
```c++
#include <iostream>
#include <cstdlib>
#include <windows.h>

using namespace std;

int main(){
	cout << "**\b\b";
	while(1){
		Sleep(250);
		cout << "  **\b\b";
	}
}
```