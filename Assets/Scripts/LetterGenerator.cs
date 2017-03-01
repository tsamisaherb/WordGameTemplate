using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterGenerator : MonoBehaviour {

	public enum FrequencyChoices
	{
		Boggle,
		Scrabble,
		Custom
	}

	public FrequencyChoices type;

	public bool UseLetterBags;
	public int BagCount = 1;
	ShuffleBag<char> bag;
	//this should be more like an enum - and use the editor to set a class
	//review how to use a non monobeahvior class
	public LetterFrequencies letterFrequency;

	void Start()
	{
		Init();
	}

	public void Init()
	{
		if(UseLetterBags)
		{
			InitBags();
		}
	}

	public void InitBags()
	{
		//create x # of bags using all of the letters 
		bag = new ShuffleBag<char>();
		int[] array = letterFrequency.LetterArray();
		Debug.Log(array.Length);
		int lettersInBag = letterFrequency.TotalCharacters();
		for(int i=0; i<BagCount; i++)
		{	
			for(int j=0; j<array.Length; j++)
			{
				for(int k=0; k<array[j]; k++)
				{
					//turns integer into character
					bag.Add(char.ConvertFromUtf32(j+65)[0]);
					Debug.Log(char.ConvertFromUtf32(j+65)[0]);
				}
			}
		}
	}


		
}