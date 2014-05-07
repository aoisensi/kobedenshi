#include <conio.h>
#include "dglib2.h"
char_far gvram;

main()
{
	dg_pset(gvram, 160, 100, RGB(255, 0, 0));
	getch();
}
