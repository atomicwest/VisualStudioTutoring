#include <iostream>

using namespace std;


// 1. hello world from [your name]
// 2. blank line
// 3. pause program to prevent console closing before key pressed


void main ()
{


	char coursereg;
	char dep;
	char coursename;
	char instr;
	char days;

	ifstream inFile;
	char path = "info.txt";
	inFile.open(path);

	inFile >> coursereg >> dep >> coursename >> instr >> days;

	

	inFile.close();

	cout << coursereg;
	cout << dep;
	cout << coursename;
	cout << instr;
	cout << days;

	system("Pause");
};
