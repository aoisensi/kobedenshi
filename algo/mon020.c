#include <stdio.h>

main()
{
	int gokei = 0;
	int i = 0;
	while(i < 300) {
		gokei += i;
		i+=8;
	}
	printf("%d", gokei);
}
