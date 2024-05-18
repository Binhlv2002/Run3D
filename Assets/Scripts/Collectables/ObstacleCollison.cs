using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject player;
    public GameObject charModel;
    public AudioSource crashThud;
    public GameObject levelControl;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Falling");
        levelControl.GetComponent<LevelDistance>().enabled = false;
        crashThud.Play();
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }
}
