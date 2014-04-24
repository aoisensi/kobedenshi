#include <stdio.h>

main()
{
	char moji[] = "ABCabc012 ";
	int i, l;
	l = sizeof(moji) - 1;
	for(i = 0; i<l; i++)
	{
		printf("%c: %2d 0x%2x\n", moji[i], moji[i], moji[i]);
	}
}
