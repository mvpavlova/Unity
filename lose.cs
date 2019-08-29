using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lose : MonoBehaviour
{

    public AudioClip loser;
    AudioSource loseaudio;
    

   public void Start()
    {
        loseaudio = GetComponent<AudioSource>();
    }

    public void gameover()
    {
        loseaudio.PlayOneShot(loser); ;
    }

}
   