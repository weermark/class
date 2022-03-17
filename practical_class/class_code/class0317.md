```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	int a = 5;
	if(a > 10){
		if(a > 1){
			cout << "bigger"; 
		}
	}
}
```

<br>

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	int i = 1;
	while(i <= 10000){ 
		i *= 2;
	}
	cout << i; 
}
```

<br>

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	int i = 1;
	int sum = 0;
	while(i >= 0){
		cout << "input: ";
		cin >> i;
		if(i >= 0){
			sum += i;
		}
	}
	cout << "sum: " << sum;
}
```

<br>

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	int i = 1;
	int sum = 0;
	while(true){
		cout << "input: ";
		cin >> i;
		if(i >= 0){
			sum += i;
		}
		else{
			break;
		}
	}
	cout << "sum: " << sum;	
}
```

<br>

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	int i = 1;
	int sum = 0;
	while(i >= 0){
		cout << "input: ";
		cin >> i;
		if(i == 1){
			continue;
		}
		else if(i >= 0){
			sum += i;
		}
		
	}
	cout << "sum: " << sum;	
}
```

<br>

```c++
#include<iostream>
#include<cstdlib>
using namespace std;

int main(){
	int num = 18;
	int time = 3;
	while(time){
		int a;
		cout << "please enter: ";
		cin >> a; 
		if(a != num){
			cout << "wrong\n";
		}
		else if(a == num){
			cout << "success!";
			break;
		}
		
		if(--time == 0){
			cout << "fail";
			break;
		}
	}
	
	return 0;
}
```