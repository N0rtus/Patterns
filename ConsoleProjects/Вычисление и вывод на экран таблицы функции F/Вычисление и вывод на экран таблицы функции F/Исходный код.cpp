#include <iostream> 

using std::cout; 
using std::cin; 

int main(void) 
{ 
	float xBeg, xEnd, a, b, c, F, step,x; 
	int i; 
	cout<<"Enter xBeg: "; 
	cin>>xBeg; 
	cout<<"Enter xEnd: "; 
	cin>>xEnd; 
	cout<<"Vvedite Shag: "; 
	cin>>step; 
	cout<<"Vvedite a: "; 
	cin>>a; 
	cout<<"Vvedite b: "; 
	cin>>b; 
	cout<<"Vvedite c: "; 
	cin>>c; 
	i=1; 
	cout<<"x"<<'\t'<<"F\n\n"; 
	for( x=xBeg; x<=xEnd; x+=step) 
{ 

	if((a<0)&&(c!=0)) 
	F=a*(x,2)+b*x+c; 
	else 
	if((a>0)&&(c==0)) 
	F=x-(a/x-c); 
	else 
{ 
	cout<<i++<<"***\n"; 
	F=a*(x/c); 
} 
	cout<<x<<'\t'<<F<<'\n'; 
} 
system("pause"); 
{ 
return 0; 
} 
}