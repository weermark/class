```c++
/*
 * 作者: 王小明						
 * 日期: 2022/03/02						
 * 作品: 輸出Hello world			
*/

#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	// store the string "Hello world"
	string s = "Hello world";
	cout << s;
}
```

<br>


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

<br>

```c++
#include <iostream>
#include <cstdlib>
#include <climits>
#include <bitset>
using namespace std;

int main(){
	unsigned int a = UINT_MAX;
	bitset<32>bit(a);
	cout << bit << " dec= "<< a << endl;
	bitset<32>bit1(a+1);
	cout << bit1 << " dec= " << a+1 << endl;
}
```

<br>

```c++
#include <iostream>
#include <cstdlib>
#include <climits>
#include <bitset>
using namespace std;

int main(){
	int a = INT_MAX;
	bitset<32>bit(a);
	cout << bit << " dec= "<< a << endl;
	bitset<32>bit1(a+1);
	cout << bit1 << " dec= " << a+1 << endl;
}
```

<br/>

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	cout << "\\" << endl;
	cout << "\'" << endl;
	cout << "\"" << endl;
	
}
```

<br>

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
	string s = "C:\\Users\\Default";
	cout << s;
}
```

<br>

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
    cout << a;
    
    cout << "\nresult2: " << endl;
    cout << b;
    
    cout << "\nresult3: " << endl;
    cout << c;

    return 0;
}
```

<br>

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