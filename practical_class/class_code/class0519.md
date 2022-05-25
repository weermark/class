```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	int a = 5;
	int* ptr = &a;
	cout << "a: " << a << ' ' << &a << endl;
	cout << "ptr: " << ptr << ' ' << &ptr << endl; 
}
```

```c++
#include<iostream>
#include<cstdlib>

using namespace std;

int main(){
	int a = 5;
	//	a: 別名為a的空間，存放整數值5 
	//	5: 整數值5

	int *b = 5; // error
	//[Error] invalid conversion from 'int' to 'int*'
}
```

```c++
#include<iostream>
#include<cstdlib>

using namespace std;

int main(){
	int tmp = 2;
	int *a = &tmp;
	int* b = &tmp;
	cout << (a == b);
} 
```

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int foo(int* p){
	*p += 10;
	return *p;
}

int main(){
	int* p;
	int a = foo(p);	// error
	cout << a;
}
```


```c++
/*
#include<iostream>
#include<cstdlib>

using namespace std;

int main(){
	cout << &5;		//error
	cout << &"dd";	//correct
	// "dd"是字串常數 
	
	char c[] = "asdfgh";
	char *str = c;
	cout << *str << endl;
	cout << str << endl;
    // 系統透過 char 陣列最末的 \0 得知字串讀完
	// 以上操作等同宣告 const char* str = "asdfgh"; 
} 
*/
```

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	int a = 3;
	int b = 5;
	int* ptr1 = &a;
	int* ptr2 = &b;
	*ptr1 = *ptr1 + *ptr2;
	cout << *ptr1;
}
```

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	int a = 5;
	int* ptr1 = &a;
	int** ptr2 = &ptr1;
	cout << ptr2  << ' ' << &ptr1 << endl;
	cout << &ptr2 << endl;
	cout << *ptr2 << ' ' << &a << endl;
	cout << **ptr2 << ' ' << a;
}
```

```c++
#include <iostream>
#include <cstdlib>
#include <vector> 

using namespace std;

int main(){
	// #include <vector>
	vector<int> v;
	v.push_back(2);                 // 把 2 加到 v 後面
	v.push_back(3);                 // 把 3 加到 v 後面
	v.pop_back();                   // 刪除 v 最後面一個元素
	cout << v.size() << endl;       // 輸出 v 已使用空間大小 (等於len)
	cout << v[0] << endl;			// 輸出 v[0]
}
```

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
	int vali = 5;
	int& refi = vali;
	int* ptri = &a;

	cout << vali;	// vali的值
	cout << &vali;	// vali的位址

	cout << refi;	// refi的值(等同vali的值)
	cout << &refi;	// refi的位址(等同vali的位址)
	// refi === vali
	cout << ptri;	// ptri的值(等同vali的位址)
	cout << &ptri;	// ptri的位址(變數ptri本身的位址)
	cout << *ptri;	// ptri所指向的位址的值(vali的值)
}
```
