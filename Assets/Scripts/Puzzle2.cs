using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    /*public GameObject Trigger1;
    public GameObject Trigger2;
    public GameObject Trigger3;
    public GameObject Door;
    public float T1Timer;
    public float T2Timer;
    public float T3Timer;
    [HideInInspector] public float T1Countdown;
    [HideInInspector] public float T2Countdown;
    [HideInInspector] public float T3Countdown;
    public float speed;
    public float DoorSolveHeight;
    private float DoorOrigin;
    private bool DoorOpen = false;
    private static bool Tcol1;
    private static bool Tcol2;
    private static bool Tcol3;

    private void Start()
    {
        DoorOrigin = Door.transform.position.y;
    }
    
    public void Update()
    {
        // Registers GameObjects rotation to a value
        float T = Door.transform.position.y;

        //Checks collision to see if door will open(This accesses an outside script)

        Tcol1 = Trigger1Col.Collided;
        Tcol2 = Trigger1Col.Collided;
        Tcol3 = Trigger1Col.Collided;
        Counting();

        // Sets countdown timer to equal timer value

        if (Tcol1)
        { 
            T1Countdown = T1Timer; 
        }
        if (Tcol2)
        {
            T2Countdown = T2Timer;
        }
        if (Tcol1)
        {
            T3Countdown = T3Timer;
        }

        //Checks to see if game object rotation is between 2 values
        if (T1Countdown <= 0 && T1Countdown <= 0 && T1Countdown <= 0)
        {
            DoorOpen = true;

        }
        else
        {
            DoorOpen = false;
        }

        if (T1Countdown >= 1 && T2Countdown >= 1 && T3Countdown >= 1)
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

        void Counting()
        {
            if (T1Countdown >=1)
            {
                T1Countdown -= T1Countdown * Time.deltaTime;
            }
            if (T2Countdown >= 1)
            {
                T2Countdown -= T2Countdown *Time.deltaTime;

            }
            if (T3Countdown >= 1)
            {
                T2Countdown -= T2Countdown * Time.deltaTime;
            }


        }
        *//* IEnumerator MovingDoor()
         {
             for (int i = 0; i < Timer; i++)
             {
                 //if (Door.transform.position )
                 Door.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
             }
             yield return new WaitForSeconds(5);

             for (int i = 0; i < CloseTimer; i++)
             {
                 Door.transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
             }
             yield return new WaitForSeconds(5);

         }*//*
    }*/
}
