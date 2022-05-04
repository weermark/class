```c++
#include <iostream>
using namespace std;

int main(){
	char str[30] = "i am a char array";
	cout << "str[0] = " << str[0] << endl;
	cout << "str[28] = " << str[28] << endl;
}
```

```c++
#include <iostream>
using namespace std;

int main(){
	char str1[10] = "abc";
	char str2[10] = {'a', 'b', 'c'};
	cout << t;
}
```

```c++
#include <iostream>
#include <string>
using namespace std;

int main(){
	string str1 = "111";
	cout << "len: " << str1.length() << endl;
	
	string str2 = "222";
	string str3 = str1 + str2;
	cout << str3;
}
```

```c++
#include <iostream>
#include <string>
using namespace std;

int main(){
	string str[3] = {"one", "two", "three"};
	cout << str[2];
}
```


```c++
#include <iostream>
#include <string>
using namespace std;

int main(){
	string str1 = "i am a human";
	cout << str1.find("am") << endl;
	cout << str1.empty() << endl;
	
	string f = "am";
	str1 = str1.replace(str1.find(f), f.length(), "are");
	cout << str1;
}
```
