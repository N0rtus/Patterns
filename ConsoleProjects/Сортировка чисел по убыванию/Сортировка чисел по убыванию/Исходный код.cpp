#include "stdio.h" 
#include "iostream" 

using std::cout; 
using std::cin; 

int main (void) 
{ 
		const int N=5; 
		int A[N+1]={0,7,5,2,4,6}; 
		int min,k,i,j,T; 
		for ( j= 1; j<=N; j++) 
		cout<<A[j]<<" "; 
		cout<<"\n\n"; 
		for ( i= 1; i<=N-1; i++) 
	{ 
		min=A[i]; 
		k=i; 
		for ( j=i+1;j<=N; j++) 
		if(A[j]>min) 
		{ 
		min=A[j]; 
		k=j; 
	} 
		if(k!=i) 
	{ 
		T=A[k]; 
		A[k]=A[i]; 
		A[i]=T; 
	} 
		for ( j= 1; j<=N; j++) 
		cout<<A[j]<<" "; 
		cout<<"\n"; 
	} 

system("pause"); 
return 0; 
 
}