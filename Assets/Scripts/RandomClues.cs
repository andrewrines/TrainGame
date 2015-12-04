using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomClues : MonoBehaviour
{
	List<string> clues = new List<string>();
	List<string> used = new List<string>();
	
	string redHerringClue;

	void Awake ()
	{
		int perpNum = Random.Range (0, 2);
		
		clues.Add ("kid1");
		clues.Add ("kid2");
		clues.Add ("kid3");
		clues.Add ("flap1");
		clues.Add ("flap2");
		clues.Add ("flap3");
		clues.Add ("med1");
		clues.Add ("med2");
		clues.Add ("med3");
		
		switch (perpNum)
		{
			case 0:
				used.Add ("kid1");
				used.Add ("kid2");
				used.Add ("kid3");
				clues.Remove ("kid1");
				clues.Remove ("kid2");
				clues.Remove ("kid3");
				break;
			case 1:
				used.Add ("flap1");
				used.Add ("flap2");
				used.Add ("flap3");
				clues.Remove ("flap1");
				clues.Remove ("flap2");
				clues.Remove ("flap3");
				break;
			case 2:
				used.Add ("med1");
				used.Add ("med2");
				used.Add ("med3");
				clues.Remove ("med1");
				clues.Remove ("med2");
				clues.Remove ("med3");
				break;
		}
		
		for (int i = 2; i < 4; i++)
		{
			int clueNum = Random.Range (0, clues.Count);
			
			used.Add (clues[clueNum]);
			clues.Remove(clues[clueNum]);
		}
		foreach (string s in used)
		{
			print (s);
		}
	}
}
