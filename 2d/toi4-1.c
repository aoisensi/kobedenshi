#include <stdio.h>
#include <stdlib.h>
#include <time.h>

main()
{
	srand(time(0));
	int k;
	k = rand() % 100;
	if(k < 30)
		printf("かいしんのいちげき！");
	else
		printf("通常攻撃");
}
