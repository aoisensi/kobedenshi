#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <conio.h>
#include "dglib2.h"

char_far gvram;

main()
{
	srand(time(0));
	int i, x, y, r, g, b;
	for(i = 0; i<500; i++) {
		x = rand() % 320;
		y = rand() % 200;
		r = rand() % 256;
		g = rand() % 256;
		b = rand() % 256;
		dg_pset( gvram, x, y, RGB(r, g, b));
	}
	getch();
}
