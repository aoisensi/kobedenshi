#include <stdio.h>
#include <stdlib.h>
#include <time.h>

main()
{
	srand(time(0));
	int k;
	k = rand() % 100;
	if(k < 30)
		printf("��������̂��������I");
	else
		printf("�ʏ�U��");
}
