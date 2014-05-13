#include <stdio.h>
#include <conio.h>
#include "dglib2.h"

char_far gvram;

main()
{
	int y;
	for(y = 0; y<200; y+=4) {
		dg_line( gvram, 0, 0, 319, y, RGB(0, y, 255));
		dg_line( gvram, 0, y, 319, 199, RGB(255, y, 0));
	}
	getch();
}
