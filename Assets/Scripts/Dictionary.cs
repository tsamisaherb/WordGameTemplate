using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour {


	TextAsset[] WordLists = new TextAsset[26];
	string[][] LetterLists = new string[26][];
	const string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	void Start()
	{
		InitializeLists();
	}

	//Assign WordList to Each Letter
	void InitializeLists()
	{
		//load lists from resources
		LoadLists();
		//split the words into string arrays;
		for(int i=0; i<WordLists.Length; i++)
		{
			LetterLists[i] = WordLists [i].text.Split("\n" [0]);
		}
	}

	//LoadLists from Resources	
	void LoadLists()
	{
		string filePathStart = "WordLists/";
		string filePathEnd = " Words";
		for(int i=0; i<26; i++)
		{
			WordLists[i] = Resources.Load<TextAsset>(filePathStart + LETTERS[i] + filePathEnd);
		}
	}

	//Check if a word is in the dictionary
	public bool CheckWord(string word)
	{
		word = word.ToLower();
		char c = word [0];
		int letterIndex = char.ToUpper(c) - 65;
		for (int i=0; i<LetterLists[letterIndex].Length; i++)
		{
			if (LetterLists[letterIndex] [i] == word)
			{
				return true;
			}
		}
		return false;
	}

}
