#include <conio.h>
#include "dglib2.h"
char_far gvram;

main()
{
	dg_line(gvram, 3, 0, 4, 0, RGB(0, 0, 255));
	dg_line(gvram, 3, 1, 4, 1, RGB(0, 0, 255));
	dg_line(gvram, 2, 2, 5, 2, RGB(0, 0, 255));
	dg_line(gvram, 1, 3, 6, 3, RGB(0, 0, 255));
	dg_line(gvram, 0, 4, 7, 4, RGB(0, 0, 255));
	dg_line(gvram, 0, 5, 7, 5, RGB(0, 0, 255));
	dg_line(gvram, 0, 6, 7, 6, RGB(0, 0, 255));
	dg_line(gvram, 1, 7, 6, 7, RGB(0, 0, 255));

	dg_box(gvram, 1, 4, 2, 3, 1, RGB(255, 255, 255));
	dg_box(gvram, 5, 4, 2, 3, 1, RGB(255, 255, 255));

	getch();
}
