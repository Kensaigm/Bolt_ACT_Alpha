using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	int OpponentFunds;  
	int PlayerFunds;

	private bool canPlay = false;
	private int playCount = 0;


	[SerializeField]
	int MaxCardsInPlay;
	[SerializeField]
	int MinCardsInPlay;


	private static GameManager s_Instance;
	public static GameManager Instance
	{
		get
		{
			if (s_Instance == null)
			{
				s_Instance = FindObjectOfType(typeof(GameManager)) as GameManager;
			}

			return s_Instance;
		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	public void GameOver()
	{
		Debug.Log("Game over!");
	}

	public void Quit()
	{
		Application.Quit();
	}
}
