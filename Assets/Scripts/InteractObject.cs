using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractObject : MonoBehaviour
{
    public Text text;
    private bool check1 = false;
   // public AudioSource playSound;
    // Start is called before the first frame update
    void Start()
    {
      
        text.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && check1 == true)
        {
            GameManager.Flag5 = true;
            //playSound.Play();
            Debug.Log("button was pressed");


        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            text.gameObject.SetActive(true);
            if (GameManager.Flag3 == true && GameManager.Flag4 == true)
            {
                text.text = "Press X to put the key on pedestal!";
                check1 = true;
               
            }
            else
            {
                check1 = false;
                text.text = "You need to find the key first!";
            }
        }
        
    }
    private void OnCollisionExit(Collision collision)
    {
        text.gameObject.SetActive(false);
    }

    // PROBLEM CODE. WILL NOT ACCEPT CONTROLLER INPUT FOR SOME REASON. HAVE TO FIX.
}
