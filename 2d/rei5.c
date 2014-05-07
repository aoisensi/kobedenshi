#include <stdio.h>

main()
{
	int key, keys;
	do {
		key = getch();
		if(key == 224) {
			keys = getch();
			printf("入力された文字コードは%d, %dです。\n", key, keys);
		} else {
			printf("入力された文字のコードは%dです。\n", key);
		}
		if(key == 'b') printf("\a");
	}
	while(key != 'e');
}
