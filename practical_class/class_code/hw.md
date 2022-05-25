## hw1

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

## teacher hw1
```c++
#include <iostream>
#include <windows.h>
using namespace std;
int main(){
for (int i = 0; i <= 4; ++i )
{
    	for (int j = 0; j <= 39; ++j )
    	{
	    	cout << "  **";
	    	cout << "\b\b";
	      //v3 = std::operator<<<std::char_traits<char>>(refptr__ZSt4cout, "  **");
	      //v4 = std::operator<<<std::char_traits<char>>(v3, 8i64);
	      //std::operator<<<std::char_traits<char>>(v4, 8i64);
	       Sleep(400);
	    }
	    cout << "  " <<  endl;
	    //std::operator<<<std::char_traits<char>>(refptr__ZSt4cout, "  ");
	    //refptr__ZSt4endlIcSt11char_traitsIcEERSt13basic_ostreamIT_T0_ES6_(refptr__ZSt4cout);
	}
    system("pause");
    return 0;
}
```

## hw2

```c++
#include<iostream>
#include<cstdlib>

using namespace std;

void solidsquare (int side, char c){
	for(int i = 0 ; i < side; i++){
		for(int j = 0 ; j < side; j++){
            cout << c ;
        }
	    cout << endl ;
    }
}

int main(){
	int side1 , side2;
	char c1 , c2;
	cout << "Integer1:";
	cin >> side1;
	cout << "Char1:";
	cin >> c1;
	cout << "Integer2:";
	cin >> side2;
	cout << "Char2:";
	cin >> c2;
	cout << "Result1:" << endl;
	solidsquare(side1, c1);
	cout << "Result2:" << endl;
	solidsquare(side2, c2);
} 
```

## hw3

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

void array(int a[], int size){
	for(int i = 0; i < size; i++){
		cout << *(a + i) << ' ';
	}
	cout << endl;
}

void reverse(int a[], int size){
	for(int i = size - 1; i >= 0; i--){
		cout << *(a + i) << ' ';
	}
	cout << endl;
}

void arrayEven(int a[], int size){
	for(int i = 1; i < size; i++){
		if(i % 2 == 0){
			cout << *(a + i) << ' ';
		}
	}
	cout << endl;
}

void arraySame(int a[], int size){
	for(int i = 0; i < size; i++){
		if(*(a + i) == i){
			cout << *(a + i) << ' ';
		}
	}
	cout << endl;
}

void min(int a[], int size){
	int min = 0;
	for(int i = 0; i < size; i++){
		if(*(a + min) > *(a + i)){
			min = i;
		}
	}
	cout << min << endl;
}


int main(){
	int a[] = {3,2,1,6,4};
	int size = sizeof(a) / sizeof(a[0]);
	cout << "Array: ";
	array(a, size);

	cout << "Reverse: ";
	reverse(a, size);

	cout << "Arrayeven: ";
	arrayEven(a, size);

	cout << "Arraysame: ";
	arraySame(a, size);
	
	cout << "Min: ";
	min(a, size);
}
```