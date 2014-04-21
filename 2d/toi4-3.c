#include <stdio.h>
#include <stdlib.h>
#include <time.h>

main()
{
	srand(time(0));
	int i;
	for(i = 0; i < 100; i++)
		printf("%d\n", rand() % 300 + 1);
}
