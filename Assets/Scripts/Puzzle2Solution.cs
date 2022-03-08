using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2Solution : MonoBehaviour
{
    [SerializeField]
    public GameObject Door;
    public float ChallengeTimer = 60;
    private float DoorTimer;
    bool collided;
    public float DoorRaiseSpeed;
    private float DoorOrigin;
    public float DoorSolveHeight;
    void Start()
    {
        //Set the tag of this GameObject to Player
        gameObject.tag = "Puzzle";
        DoorOrigin = Door.transform.position.y;
    }

    private void OnTriggerEnter(Collider other)
    {
        collided = true;

    }

    private void OnTriggerExit(Collider other)
    {

        collided = false;
    }

    void Update()
    {
        float T = Door.transform.position.y;

        if (collided) 
        {
            DoorTimer = ChallengeTimer;
        }

        if (!collided && DoorTimer >= 1) 
        {
            Debug.Log("Get through the door!");
            DoorTimer -= DoorTimer * Time.deltaTime;
            Door.transform.position += new Vector3(0, DoorRaiseSpeed * Time.deltaTime, 0);
        }
       
        else if (T > DoorOrigin && DoorTimer <= 1)
        {
            Door.transform.position -= new Vector3(0, DoorRaiseSpeed * Time.deltaTime, 0);
        }




    }
}
