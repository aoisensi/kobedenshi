#include <stdio.h>

main()
{
	float PI = 3.14;
	float r = 5.0;
	while(r < 20.0) {
		printf("%.2f\n", r * r * PI);
		r += 3.0;
	}
}
