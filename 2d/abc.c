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
		printf("%c ����͂��Ă���������", ans[cnt]);
		key = getche();
		printf("\n");
		if (tolower(key)==ans[cnt] ){
			cnt++;
		}else{
			printf("���̓~�X�I\n\a");
			miss++;
		}
	}
	
	printf("���̓^�C����%ld\n", time(0) - start);
	
	printf("�~�X�񐔂�%d��\n", miss);
}
