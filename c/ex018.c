#include <stdio.h>

main()
{
	int a, b, c;
	printf("整数を3つ入力");
	scanf("%d%d%d", &a, &b, &c);
	printf("合計:%d", a+b+c);
	printf("平均:%d", (a+b+c)/3.0);
}
