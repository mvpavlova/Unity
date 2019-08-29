using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track1 : MonoBehaviour {

    AudioSource player;
    public AudioClip track;

    private void Start()
    {
        player = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.PlayOneShot(track);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.Stop();
        }
    }
}
