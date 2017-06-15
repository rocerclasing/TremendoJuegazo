using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

    public int points;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<PlayerController>() == null)
        {
            return;
        } else
        {
            ScoreManager.AddPoints(points);
            Destroy(gameObject);
        }
    }

	void Start () {
		
	}
	
	void Update () {
		
	}
}
