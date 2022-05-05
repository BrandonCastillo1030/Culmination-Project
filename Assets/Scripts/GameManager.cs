//  Made by Jonathan Clement
//  Sript: puzzle 1

/*      This Script was made to control set flags(Requirements) in the game. This also records The artifacts collected and controls
 *      the final activated door*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Door;
    public GameObject KeyObj;
    public Image Key;
    //public AudioSource playSound;

    public static bool Flag1 = false;
    public static bool Flag2 = true;
    public static bool Flag3 = true;
    public static bool Flag4 = true;
    public static bool Flag5 = false;
    public static int Relic = 0;
    public static int Placed = 0;

    public float DoorSolveHeight;
    private float DoorOrigin;
    public float speed;
    private float T;

    // Start is called before the first frame update
    void Start()
    {
        //Key.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //This code records the original position of the door
        T = Door.transform.position.y;

        //This code checks if all 3 relics have been collected then sets a flag to be true(Active)
        if (Relic == 3)
        {
            Flag1 = true;

            Debug.Log("You have all three relics!!!");
        }
        //This code checks to see if all 3 relics have been placed in their proper locations
        if (Placed == 3)
            Flag2 = true;
        {
            Completed();

        }
        void Completed()
        {
            if (Flag2 == true)
            {

                Debug.Log("Solved!");
                if (T <= DoorSolveHeight)
                {
                    Door.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
                    
                }

            }
            else
            {
                if (T > DoorOrigin)
                {
                    Door.transform.position -= new Vector3(0, speed * Time.deltaTime, 0);

                }

            }
        }
        if (Flag3 == true)
        {
            //KeyObj.SetActive(true);
            //Key.gameObject.SetActive(true);
        }
        else
        {
            //KeyObj.SetActive(false);
        }

        
    }

    

}


