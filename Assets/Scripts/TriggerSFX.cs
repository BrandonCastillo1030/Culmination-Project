using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource playSound;

    void OnTriggerEnter(Collider other)
    {
        playSound.Play();   
       
    }
    void update()
    {
        if (GameManager.Flag5 == true)
        {
            playSound.Play();
            Debug.Log("The Tuneskis");
        }
    }
}
