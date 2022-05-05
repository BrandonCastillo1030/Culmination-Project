using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGoDown : MonoBehaviour
{
    public GameObject Door;
    public float DoorSolveHeight;
    private float DoorOrigin;
    public float speed;
   // public AudioSource playSound;



    // Start is called before the first frame update
    void Start()
    {
        DoorOrigin = Door.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float T = Door.transform.position.y;

        if (GameManager.Flag5 == true)
        {
            //playSound.Play();
            if (T <= DoorSolveHeight)
            {
                
                Door.transform.position -= new Vector3(0, speed * Time.deltaTime, 0);

            }

        }
        else
        {
            if (T > DoorOrigin)
            {
                Door.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            }

        }

    }



}
