#include <stdio.h>

main()
{
	int key, keys;
	do {
		key = getch();
		if(key == 224) {
			keys = getch();
			printf("���͂��ꂽ�����R�[�h��%d, %d�ł��B\n", key, keys);
		} else {
			printf("���͂��ꂽ�����̃R�[�h��%d�ł��B\n", key);
		}
		if(key == 'b') printf("\a");
	}
	while(key != 'e');
}
