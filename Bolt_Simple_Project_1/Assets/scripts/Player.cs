using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField]
	int StartingFunds;
	[SerializeField]
	int CurrentFunds;
	[SerializeField]
	int CostPerMove;
	[SerializeField]
	int CostPerDraw;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Transform child in transform)
		{
			if (child.tag != "Player")
			{
				child.tag = "Player";
				Debug.Log(child.transform.gameObject.name);
			}
		}

	}

	//List<GameObject> getHand()
	//{
	//	List<GameObject> Children;

	//	foreach (Transform child in transform)
	//	{
	//		if (child.tag == "Player")
	//		{
	//			Children.Add(child);
	//		}
	//	}

	//	return Children;
	//}

	void getDeck()
	{

	}

	void getCard()
	{
		CurrentFunds = CurrentFunds - CostPerDraw;
	}

	void playCard()
	{
		CurrentFunds = CurrentFunds - CostPerMove;
	}
}
