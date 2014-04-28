#include <stdio.h>

main() {
	char moji1, moji2;
	moji1 = '5';
	moji2 = '6';
	printf("%c x %c = %d\n", moji1, moji2, (moji1 - '0') * (moji2 - '0'));
}

