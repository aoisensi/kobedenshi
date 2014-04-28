#include <stdio.h>
#include <stdlib.h>
#include <time.h>

main()
{
	int in, en, re;
	srand(time(0));
	rand();
	en = rand() % 3;

	printf("何を出しますか？");
	printf("(0:グー  1:チョキ  2:パー) ＞");
	scanf("%d", &in);
	printf("\n");


	if(in == 0)
		printf("プレイヤーはグーです。\n");
	else if(in == 1)
		printf("プレイヤーはチョキです。\n");
	else if(in == 2)
		printf("プレイヤーはパーです。\n");

	if(en == 0)
		printf("相手はグーです。\n");
	else if(en == 1)
		printf("相手はチョキです。\n");
	else if(en == 2)
		printf("相手はパーです。\n");

	re = (en - in + 3) % 3;
	if(re == 0)
		printf("あいこです\n");
	else if(re == 1)
		printf("勝ちです\n");
	else if(re == 2)
		printf("負けです\n");
}
