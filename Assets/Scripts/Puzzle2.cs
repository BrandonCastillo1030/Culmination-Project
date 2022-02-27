using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    private float Timer = 0f;
    private float DoorTimer = 0f;
    public float DoorTimer2 = 15f;
    public float MaxTimer = 15f;
    
    public GameObject Door;
    float t;
    Vector3 startPosition;
    Vector3 target;
    float DoorClosetime = 3;

    private void OnCollisionEnter(Collision collision)
    {
        Timer = MaxTimer;
        DoorTimer = DoorTimer2;
        startPosition = target = transform.position;

    }

    private void OnCollisionExit(Collision collision) 
    {
        /* Set timer 2 to count down, once the timer is done. make the door 
          shut by timer 1 count down*/
       while (DoorTimer > 1) 
        {
            DoorTimer -= Time.deltaTime;
            t += Time.deltaTime / DoorClosetime;
            transform.position = Vector3.Lerp(startPosition, target, t);
        }

        if (DoorTimer == 0)
        {
            while (Timer >1 )
            {
                Timer += Time.deltaTime;
            }

        }
    }
    public void SetDestination(Vector3 destination, float time)
    {
        t = 0;
        startPosition = transform.position;
        DoorClosetime = time;
        target = destination;
    }

    void Update()
    {
        if (Timer <1  && DoorTimer < 1)
        {
            Timer = MaxTimer;
            DoorTimer = DoorTimer2;
        }
    }
   
}
