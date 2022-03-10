```c++
#include <iostream>
#include <cstdlib>
#include <typeinfo>

using namespace std;

int main(){
    int a = 5;
    int b = 3;
    cout << typeid((float)a/b).name();
}
```

<br>

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int main(){
    int a, b, c;
    int max;
    cout << "start key in 3 num:" << endl;
    cin >> a;
    max = a;
    cin >> b;
    max = (max > b) ? max : b;
    cin >> c;
    max = (max > c) ? max : c;
    cout << endl << "max is: ";
    cout << max;
}
```
