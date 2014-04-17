#include <stdio.h>

int cell[361];

void printfield() {
	int i;
	for (i = 0; i < 361; i++) {
		switch (cell[i]){
		case -1:
			printf("Åõ");
			break;
		case 1:
			printf("Åú");
			break;
		default:
			if (i < 19) {
				if (i % 19 == 0)
					printf("Ñ°");
				else if (i % 19 == 18)
					printf("Ñ¢");
				else
					printf("Ñ¶");
			}
			else if (i > 341) {
				if (i % 19 == 0)
					printf("Ñ§");
				else if (i % 19 == 18)
					printf("Ñ£");
				else
					printf("Ñ®");
			}
			else {
				if (i % 19 == 0)
					printf("Ñ•");
				else if (i % 19 == 18)
					printf("Ñß");
				else {
					int t1, t2;
					t1 = i / 19;
					t2 = i % 19;
					if ((t1 == 3 || t1 == 9 || t1 == 15) && (t2 == 3 || t2 == 9 || t2 == 15))
						printf("Åû");
					else
						printf("Ñ©");
				}
			}
			break;
		}
		if (i % 19 == 18) printf("\n");
	}
}

void plzset(int p, int e)
{
	
}

main()
{
	int i, ban, x, y;
	for (i = 0; i < 361; i++) {
		cell[i] = 0;
	}
	ban = 1;
	while(1) {
		printfield();
		if(ban > 0) {
			printf("êÊéËÇÃî‘Ç≈Ç∑\n");
		} else {
			printf("å„éËÇÃî‘Ç≈Ç∑\n");
		}
		while (1) {
			scanf("%d %d", &x, &y);
			if(0 < x && x < 20 && 0 < y && y < 20)
			
		}
		cell[x * 19 + y] = ban;
		ban *= -1;
	}

}



