using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalLevel : MonoBehaviour
{
    /*This section of code makes it so that we can track the status of the relics and a text object. It also makes it so they can be affected by a check
     that is a bool(True or False)*/
    public GameObject Relic;
    public Text text;
    private bool check = false;
    public bool check2 = false;
    

    // Start is called before the first frame update
    void Start()
    {
        // This makes the game objects (the relic and text) not appear in the game until reactivated
        Relic.gameObject.SetActive(false);
        text.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        //This checks if the player collides with the object this script is attached to. And if they do collide it does the actions below.
        // This sets the text to become active, then it changes one of the checks to be true
        text.gameObject.SetActive(true);
        check = true;
    }

    private void OnTriggerExit(Collider other)
    {
        // This checks to see when the player stops colliding with the object this script is attatched to.
        // This sets the text back to being inactive and sets the check back to being false;
        text.gameObject.SetActive(false);
        check = false;
    }
    // Update is called once per frame
    void Update()
    {
        RelicPlace();
    }
    void RelicPlace() 
    {
        /* This code does many things
         * It first checks to see if both flags (Check and Check2) are both set to true, it also checks to see if the player has all three relics
         * Then the code checks to get the set Ineract button from the player (X on xbox controller) 
         * If all of this is seen by this system, it then makes the relic appear on the pedistall, and it add's 1 to the value of placed relics
         * It also sets check 2 to be true if all the relics have been placed
         * The code WILL NOT work if the placed value is greater than 3*/
        if (GameManager.Placed > 3)
        {
            check2 = true;
            Debug.Log("you cannot place more Relics!");

        }
        else if (check2 == false && check == true && GameManager.Relic == 3)
        {
            if (Input.GetButtonDown("Interact"))
            {
                Relic.gameObject.SetActive(true);
                GameManager.Placed = GameManager.Placed + 1;

            }
        }
    }

 
    }

