using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
	public int coin = 0;


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Coin")) // Detection of Coin
		{
			coin += 1;
			Debug.Log("Something Touched me");
			ScoreSystem.theScore = coin;

			Destroy(other.gameObject); //Destroy Coin

		}
	}
}
