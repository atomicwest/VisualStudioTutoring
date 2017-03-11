// MapsAndEnum.cpp : Defines the entry point for the console application.
// Count the frequencies of vowels in the letters then correspond to animal codes

#include "stdafx.h"
#include <iostream>
#include <string>
#include <map>

using namespace std;

enum animals { Alligators, Elephants, Ibises, Oysters, Urchins, NotAnimal };

bool IsVowel(char letter) {
	char lwr = toupper(letter);
	string vowels = "AEIOU";
	for (int i =0; i<vowels.length(); i++) {
		if (vowels[i]==lwr) {
			return true;
		}
	}
	return false;
}

map<char, int> countLetters(string phrase){
	map<char, int> freqs;
	for (int i=0; i<phrase.length(); i++) {
		if (IsVowel(phrase[i])){
			freqs[toupper(phrase[i])]++;
		}
	}
	return freqs;
}

animals encode(char code) {
	switch (code) {
		case 'A':
			return Alligators;
			break;
		case 'E':
			return Elephants;
			break;
		case 'I':
			return Ibises;
			break;
		case 'O':
			return Oysters;
			break;
		case 'U':
			return Urchins;
			break;
		default:
			NotAnimal;
	}
}

void printer(map<char, int> freqs) {
	
	char *cd[] = {
		"Alligators",
		"Elephants",
		"Ibises",
		"Oysters",
		"Urchins"
	};

	for (map<char,int>::iterator j=freqs.begin(); j!=freqs.end(); j++){
		cout << cd[encode(j->first)] << ": " << j->second << endl;
	}
}

void main() {
	string phrase;
	
	cout << "Enter phrase: " << endl;
	getline(cin, phrase);
	cout << endl;

	printer(countLetters(phrase));
	system("PAUSE");
}
