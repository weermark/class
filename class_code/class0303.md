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