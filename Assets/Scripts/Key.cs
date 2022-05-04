using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public AudioSource playSound;


    private void OnCollisionEnter(Collision collision)
    {
       GameManager.Flag4 = true;
       Destroy(gameObject);
        playSound.Play();

    }
}
