```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int fact(int n){
   if(n == 0)  return 1;
   return n * fact(n - 1);
}

int main(){
   int res = fact(3);
   cout << res;
}
```

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int fibonacci(int n){
   if(n == 1)	return 1;
   if(n == 2)	return 1;
   return (fibonacci(n - 1) + fibonacci(n - 2));
}

int main(){
   cout << fibonacci(10);
}
```

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int gcd(int a, int b){
   if(b == 0)  return a;
   return gcd(b, a % b);
}

int main(){
   int res = gcd(12, 32);
   cout << res;
}
```

```c++
#include <iostream>
#include <cstdlib>

using namespace std;

int walk(int n){
   if(n == 1)  return 1;
   if(n == 2)  return 2;
   return (walk(n - 1) + walk(n - 2));
}

int main(){
   int res = walk(10);
   cout << res;
}
```

```c++

```
