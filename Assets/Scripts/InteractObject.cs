using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractObject : MonoBehaviour
{
    public Text text;
    private bool check1 = false;
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
            GameManager.Flag3 = true;
            Debug.Log("button was pressed");

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Interactable")
        {
            text.gameObject.SetActive(true);
            if (GameManager.key == true)
            {
                text.text = "Press X to place the key on pedistal!";
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
