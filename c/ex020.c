#include <stdio.h>

main()
{
	char c;
	printf("小文字を入力:")
	scanf("%c", &c);
	printf("あなたが入力した文字の大文字は%c", c + ('A' - 'a'));
}
