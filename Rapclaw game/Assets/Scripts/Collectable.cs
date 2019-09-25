using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		HandleCollected();
	}

	void HandleCollected()
	{
		print("I've been collected");
		Destroy(gameObject);
	}
}
