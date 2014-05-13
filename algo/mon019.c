#include <stdio.h>

main()
{
	int gokei = 0;
	int i = 1;
	while(i < 500) {
		gokei += i;
		i++;
	}
	printf("%d", gokei);
}
