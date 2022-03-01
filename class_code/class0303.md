```c++
#include <iostream>
#include <cstdlib>
#include <climits>
using namespace std;

int main(){
	int a = INT_MAX;
	cout << a << ' ' << a+1 << endl;

	unsigned int b = INT_MAX;
	cout << b << ' ' << b+1 << endl;
	
	unsigned int c = UINT_MAX;
	cout << c << ' ' << c+1;
}
```

<br/>


```c++
#include <iostream>
#include <cstdlib>
#include <windows.h>

using namespace std;

int main(){
	cout << "time: ";
	for(int i = 1; i <= 10; i++){
		cout << '\a' << i << '\b';
		Sleep(1000);
	}
}
```

<br/>

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	cout << "\\\"\\t\\b";
	
	return 0;
}
```

<br/>

```c++
#include <iostream>
#include <cstdlib>
using namespace std;

int main(){
	for(int i = 1; i <= 9; i++){
		for(int j = 1; j <= 9; j++){
			cout << i << '*' << j << '=' << i*j << '\t';
		}
		cout << endl;
	}
	return 0;
}

```

<br/>

```c++

```

<br/>

```c++

```

<br/>

```c++

```