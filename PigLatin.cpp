// PigLatin.cpp : Translate a word to Pig Latin
//

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

bool startVowel(string word){
	
	char first = word[0];

	string vowels = "aeiou";
	for (int i=0; i<vowels.length(); i++) {
		if (vowels[i] == first) {
			return true;
		}
	}
	return false;
}


string pigVowel(string word) {
	string outWord = word;

	if (outWord[outWord.length()-1] == 'y'){
		outWord.append("ay");
	} else {
		outWord.append("yay");
	}

	return outWord;
}


string pigConsonant(string word) {	

	string outWord = word.substr(1,word.length());
	string first(1, word[0]);
	outWord.append(first);
	outWord.append("ay");
	return outWord;
}

void main() {
	string word;
	
  cout << "Enter a word to translate: ";
	cin >> word;
	cout << endl << endl << endl;
	cout << "In Pig Latin: " << endl << endl;
  
	if (startVowel(word)) {
		cout << pigVowel(word) << endl << endl;
	} else {
		cout << pigConsonant(word) << endl << endl;
	}

	system("PAUSE");
}
