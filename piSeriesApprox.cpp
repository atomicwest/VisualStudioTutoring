// PiCh6CIS.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

/*
int _tmain(int argc, _TCHAR* argv[])
{
	return 0;
}
*/

void main()
{
	double pi = 1.0;
	long i;
	long n;

	cout << "Enter the value of n: " ;
	cin >> n;
	cout << endl;

	for ( i=1; i < n+1; i++) 
	{
		//pi = 0;
		
		if (i%2 == 0)
		{
			pi = pi + (1/(2.0*i + 1));
		} 
		else
		{
			pi = pi - (1/(2.0*i + 1));
		}

	}

	pi = 4 * pi;

	cout << endl << "pi = " << pi << endl;

	system("PAUSE");
}
