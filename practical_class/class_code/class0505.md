```c++
#include <iostream>
using namespace std;

int main(){
	char str1[] = "abc";				// 字串 
	char str2[] = {'a', 'b', 'c'};		// 字元
	
	cout << str1 << ' ' << str2 << endl;
	cout << (str1 == str2);
}
```

```c++
#include <iostream>
using namespace std;

int main(){
	char str[10] = "abcde";
	// char str[10] = {'a','b','c','d','e'};
	cout << str[0] << endl;
	cout << str[9] << endl;
}
```

```c++
#include <iostream>
using namespace std;

int main(){
	string s = "aaaaa";
	s[2] = "b";		//error
}
```

```c++
#include <iostream>
#include <string>
using namespace std;

int main(){
	string str1 = "aaa";
	// string str1("aaa");
	cout << "len : " << str1.length() << endl;
	cout << "size: " << str1.size() << endl;

	string str2 = "bbb";
	string str3 = str1 + str2;
	cout << str3;
}
```

```c++
#include <iostream>
#include <string>
using namespace std;

int main(){
	char c[4] = "one";		// 一維陣列 
	string str[3] = {"one", "two", "three"};	// 二維陣列 
	cout << str[2];
}
```


```c++
#include <iostream>
#include <string>
using namespace std;

int main(){
	string str1 = "";
	cout << str1.empty() << endl;
	str1 = "i an a human";
	cout << str1.find("an") << endl;
	cout << str1.empty() << endl;
	
	string f = "an";
	str1 = str1.replace(str1.find(f), f.length(), "are");
	cout << str1;
}
```

```c++
#include <iostream>
using namespace std;

int main(){
	string str = "i am a student";
	string tmp = "student";
	str =  str.replace(str.find(tmp), tmp.length(), "good guy");
	cout << str;
}
```

```c++
#include <iostream>
using namespace std;

int main(){
	string str;
	cout << "enter a num:" << endl;
	cin >> str;
	int res = stoi(str) + 1;
	cout << res;
}
```

```c++
#include <iostream>
#include <string>
using namespace std;

int main(){
	string str = "abcde";
	string res = "";
	for(int i = str.length() - 1; i >= 0; i--){
		res += str[i];
	}
	cout << res;
}
```

```c++
#include <iostream>
using namespace std;

int main(){
	string str;
	cout << "please enter a string:" << endl;
	cin >> str;
	for(int i = str.length() - 1, j = 0; i >= j; i--, j++){
		char tmp = str[i];
		str[i] = str[j];
		str[j] = tmp;
	}
	cout << str;
}
```
