#include <stdio.h>
#include <stdlib.h>
#include <time.h>

main()
{
	int in, en, re;
	srand(time(0));
	rand();
	en = rand() % 3;

	printf("�����o���܂����H");
	printf("(0:�O�[  1:�`���L  2:�p�[) ��");
	scanf("%d", &in);
	printf("\n");


	if(in == 0)
		printf("�v���C���[�̓O�[�ł��B\n");
	else if(in == 1)
		printf("�v���C���[�̓`���L�ł��B\n");
	else if(in == 2)
		printf("�v���C���[�̓p�[�ł��B\n");

	if(en == 0)
		printf("����̓O�[�ł��B\n");
	else if(en == 1)
		printf("����̓`���L�ł��B\n");
	else if(en == 2)
		printf("����̓p�[�ł��B\n");

	re = (en - in + 3) % 3;
	if(re == 0)
		printf("�������ł�\n");
	else if(re == 1)
		printf("�����ł�\n");
	else if(re == 2)
		printf("�����ł�\n");
}
