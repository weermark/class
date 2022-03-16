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
	int i = 2;
	int time = 1;
	int stop = 5;
	while(time <= 20){
		i++;
		if(i % 3 == 0 || i % 5 == 0){
			if(time == stop){
				cout << endl;
				stop += 5;
				continue;
			}
			else{
				cout << "time" << time << ": " << i << endl;
				time++;
			}
		}
	}
}
```