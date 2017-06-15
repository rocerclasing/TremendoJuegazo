using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject currentCheckPoint;
    private PlayerController player;

    public int pointsOnDeath;

    public GameObject deathParticle;
    public GameObject respawnParticle;

    public float respawnDelay;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    void Update()
    {

    }

    public void RespawndPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        Instantiate (deathParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        ScoreManager.AddPoints(-pointsOnDeath);
        Debug.Log("Reapareciendo...");
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = currentCheckPoint.transform.position;
        player.GetComponent<Rigidbody2D>().gravityScale = 20;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled =true;
        Instantiate (respawnParticle, player.transform.position, player.transform.rotation);
    }
}