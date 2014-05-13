#include <stdio.h>

main()
{
	int a, b, ans = 0;
	scanf("%d %d", &a, &b);
	while(b > 0)
	{
		ans += a;
		b--;
	}
	printf("%d\n", ans);
}
