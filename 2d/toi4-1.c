#include <stdio.h>
#include <stdlib.h>
#include <time.h>

main()
{
	srand(time(0));
	int k;
	k = rand() % 100;
	if(k < 30)
		printf("‚©‚¢‚µ‚ñ‚Ì‚¢‚¿‚°‚«I");
	else
		printf("’ÊíUŒ‚");
}
