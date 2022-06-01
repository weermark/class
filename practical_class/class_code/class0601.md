```c++
#include <iostream>
#include <cstring>
using namespace std;

int main(){
	int a = 5;
	int* ptr1 = &a;
	int** ptr2 = &ptr1;
	**ptr2 *= 2;
	cout << **ptr2 << ' ' << *ptr2;
}
```

```c++
#include <iostream>
#include <cstring>
using namespace std;

int main(){
	int a[3][4] = {{1,2,3,4},
				   {5,6,7,8},
				   {9,10,11,12}};
	cout << *(*(a + 1) + 3);
	//cout << a[1][3];
}
```

```c++
#include <iostream>
#include <cstring>
using namespace std;

int main(){
	int *b = new int(5);
	cout << *b << " " << b << endl;
	b = new int(2);
	cout << *b << " " << b << endl;
	delete b;
	cout << *b << " " << b;	// wrong
}
```

```c++
#include <iostream>
#include <cstring>
using namespace std;

int main(){
	int *b = new int(5);
	int& ref = *b;
	cout << &ref << ' ' << b << endl;
}
```

```c++
#include <iostream>
#include <cstring>
using namespace std;

class Array{
	private:
		int len;
		int size;
		int *arr;
	public:
		Array(int size){
			this->len = -1;
			this->size = size;
			arr = new int[size];
		}
		~Array(){
			delete[] arr;
		}
		void add(int val){
			if(len + 1 == size){
				cerr << "full!" << endl;
				return;
			}
			++len;
			arr[len] = val;
		}
		void pop(){
			if(len == -1){
				cerr << "empty!" << endl;
				return;
			}
			cout << "pop " << arr[len] << endl;
			len--;
		}
		int length(){
			return len + 1;
		}
		int getSize(){
			return size;
		}
		void print(){
			if(len < 0){
				return;
			}
			for(int i = 0; i <= len; i++){
				cout << arr[i] << ' ';
			}
			cout << endl;
		}
};
int main(){
	Array a(5);
	a.add(3);
	a.print();
	cout << a.getSize() << ' ' << a.length() << endl;
	a.add(6);
	a.add(2);
	a.add(1);
	a.add(6);
	a.pop();
	a.add(9);
	a.add(1);
	cout << "len: " << a.length() << endl;
	a.print();
}
```