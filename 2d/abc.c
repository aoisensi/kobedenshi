#include <stdio.h>
#include <time.h>
#include <ctype.h>
#include <string.h>

main()
{
	int cnt, miss;
	char key, ans[] = "abcdefghijklmnopqrstuvwxyz";

	time_t  start;
	start = time(0);

	cnt = 0;
	miss = 0;

	while( cnt < strlen(ans) ){
		printf("%c を入力してください＞", ans[cnt]);
		key = getche();
		printf("\n");
		if (tolower(key)==ans[cnt] ){
			cnt++;
		}else{
			printf("入力ミス！\n\a");
			miss++;
		}
	}
	
	printf("入力タイムは%ld\n", time(0) - start);
	
	printf("ミス回数は%d回\n", miss);
}
