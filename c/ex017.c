#include <stdio.h>

main()
{
	float a, b, c;
	printf("一つ目の実数:");
	scanf("%f", &a);
	printf("二つ目の実数:");
	scanf("%f", &b);
	printf("三つ目の実数:");
	scanf("%f", &c);
	printf("合計:%f 平均:%f", (a*b*c), (a*b*c)/3);
}
