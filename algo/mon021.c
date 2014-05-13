#include <stdio.h>

main()
{
	int kai = 1;
	int i = 1;
	while(i < 10) {
		kai *= i;
		i++;
	}
	printf("%d", kai);
}
