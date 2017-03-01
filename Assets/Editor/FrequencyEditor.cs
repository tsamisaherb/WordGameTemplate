using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Dictionary))]
public class FrequencyEditor : Editor {


	public override void OnInspectorGUI() 
	{
		//Way to choose letter frequency

	}

	//way to show 26 options (closeable) with the % of each letter
	//If custom than these are editable, otherwise they aren't
}
