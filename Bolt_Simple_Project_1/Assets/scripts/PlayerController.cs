using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Camera camera;

	

	// Use this for initialization
	void Start()
	{
		camera = Camera.main;
		camera.enabled = true;

	}

	// Update is called once per frame
	void Update()
	{

		int playerCards;

		if (Input.GetMouseButtonDown(0))
		{


			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, 100))
			{
				Debug.Log(hit.transform.gameObject.name);
				Debug.Log(hit.transform.gameObject.tag);


			}
		}
	}
}
