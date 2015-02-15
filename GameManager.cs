using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	
	public Text collectablesText;
	
	private int nrOftotalCollecables;
	private int nrOfCollectedItems;
	
	void Start()
	{
		GameObject[] objects = GameObject.FindGameObjectsWithTag ("Collectable");
		nrOftotalCollecables = objects.Length;
		nrOfCollectedItems = 0;
		UpdateUI();
	}
	
	public void AddCollectable()
	{
		nrOfCollectedItems++;
		UpdateUI ();
	}
	
	void UpdateUI()
	{
		collectablesText.text = "Collectables: " + nrOfCollectedItems + " / " + nrOftotalCollecables;
	}
}
