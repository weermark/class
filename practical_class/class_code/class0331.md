```c++
#include <iostream>
using namespace std;

int main(int argc, char *argv[]) {
	cout << "argc:" << argc << endl;
	for(int i = 0; i < argc; i++){
		cout << i << "  " << argv[i] << endl;
	} 
}
// g++ path/file.cpp
// a.exe i j k
```

```c++
#include <iostream> 
using namespace std;

int f(int x){
	return x + 1;
}

int main() {
	cout << f(5);
}
```

```c++
#include <iostream> 
using namespace std;

void f(int x){
	cout << x + 1;
}

int main() {
	f(5);
}
```

```c++
#include <iostream>
using namespace std;

int min(int a, int b){
	return(a < b ? a : b);
}

int main(){
	int small = min(5, 3);
	cout << small;
}
```

```c++
#include <iostream>
using namespace std;

void min(int a, int b){
	cout << (a < b ? a : b);
}

int main(){
	min(5, 3);
}
```


```c++
#include <iostream> 
using namespace std;

int abs(int x){
	return (x < 0 ? -x : x);
}

int main() {
	int a = abs(-5);
	cout << a;
}
```

```c++

```

```c++

```