#include <stdio.h>

main()
{
	int s;
	scanf("%d", &s);
	if(s%400==0 || (s%4==0 && s%100>0))
		printf("うるう年です\n");
	else
		printf("うるう年ではない\n");
}
