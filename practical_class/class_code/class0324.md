```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
	int n;
	cout << "input: ";
	cin >> n;
	cout << endl;
	for(int i = 1; i <= n; i++){
		if(i == 1 || i == n){
			string s(n, '*');
			cout << s;
		}
		else{
			string s(n-2, ' ');
			cout << '*' << s << '*';
		}
		cout << endl;
	}
}
```

<br>

[其他程式碼](https://gist.github.com/bibo2001/9f2d42c26d29e85459ae942873b7a69e)
