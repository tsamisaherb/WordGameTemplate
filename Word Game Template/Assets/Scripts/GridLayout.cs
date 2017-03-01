using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridLayout : MonoBehaviour {


	List<LetterTile> letters = new List<LetterTile>();

	public class LetterTile
	{
		string letter;
		public int GridX;
		public int GridY;
		public int GridID;
		public LetterTile(int x, int y, int ID)
		{
			this.GridX = x;
			this.GridY = y;
			this.GridID = ID;
		}
	}

	string RandomLetter()
	{
		return "a";
	}



	//	public LetterTile[] ReplaceLetters(int[] gridIDs)
	//	{
	//		//return new letters in the proper IDS;
	//	}

	void MakeNewLetterInSpot(int gridID)
	{

	}

	void MakewNewLetterInGrid(int GridX, int GridY)
	{

	}
}
