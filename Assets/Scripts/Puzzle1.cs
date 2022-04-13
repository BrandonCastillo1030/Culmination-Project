//  Made by Jonathan Clement
//  Sript: puzzle 1

/*      This Script was made to Rotate a pillar to a specified degree to meet a set requirement.
    After the requirement is met, the Door will open, leading to the next location that was
    Previously unaccessible to the player.     */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    [SerializeField]
    public GameObject Pillar1;
    public float rotationSpeed = 20;
    bool collided;
    bool isturned = false;
    public float degreesPerSecond = .1f;
    void Start()
    {
        //Set the tag of this GameObject to Player
        gameObject.tag = "Puzzle";
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
        // Records pillars current rotation and checks for collission

        float T = Pillar1.transform.eulerAngles.y;

        Debug.Log("World Space rotation: " + T);
        Debug.Log("Local Rotation: " + Pillar1.transform.localEulerAngles.y);

            if (collided)
            {
                Pillar1.transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));

                //Debug.Log(T);
                isturned = true;
            }
        
    }

}

