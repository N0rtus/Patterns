#include "stdio.h" 
#include "iostream" 

using std::cout; 
using std::cin; 

int main (void) 
{ 
	const int N=5; 
	int A[N+1]={0,7,5,2,4,6};
	int i,j,T; 
	for ( j= 1; j<=N; j++) 
	cout<<A[j]<<" "; 
	cout<<"\n\n"; 
	for ( i=1;i<=N-1;i++) 
	for ( j=1;j<=N-i;j++) 
	if(A[j]>A[j+1])

	{ 

	T=A[j]; 
	A[j]=A[j+1]; 
	A[j+1]=T; 

	}

	for ( j= 1; j<=N; j++) 
	cout<<A[j]<<" "; 
	cout<<"\n"; 

system("pause"); 

return 0; 
}