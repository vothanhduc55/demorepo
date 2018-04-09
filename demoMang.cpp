#include<stdio.h>
#include<conio.h>
int main(){
	int i = 0;
	int a[10];
	int n = 10;
	int tongchan = 0;
	int temp =0;
	for(i=0; i<n;i++){
		printf("nhap phan tu thu %d: ",i);
		scanf("%d",&a[i]);
	}
	
	for(i=0; i<n; i++){
	printf("%5d",a[i]);
	}
	printf("Cac so chan la: \n");
	for(i=0; i<n; i++){
		if(a[i]%2 == 0){
			printf("%d\n",a[i]);
			tongchan = tongchan + a[i];
		}
		
	}
	printf("tong cua day so chan: %d",tongchan);
	
	for(i=0; i<n;i++){
		if(a[i]<a[i+1]){
			temp = a[i];
		}
		else{
			
		}
	}
}
