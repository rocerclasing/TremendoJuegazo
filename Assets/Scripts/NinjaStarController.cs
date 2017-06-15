using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStarController : MonoBehaviour {

    public float speed;
    public PlayerController player;

    public Transform enemyDeath;
    public Transform ninjaStarParticle;

    void Start () {
        player = FindObjectOfType<PlayerController>();

        if(player.transform.localScale.x < 0)
        {
            speed = -speed;
        }
	}
	
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            Instantiate(ninjaStarParticle, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        } else if(other.gameObject.layer == 9)
        {
            Instantiate(ninjaStarParticle, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }



    }
}
