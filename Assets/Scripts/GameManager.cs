using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Door;

    public bool Flag1 = false;
    public bool Flag2 = false;
    public bool Flag3 = false;
    public static int Relic = 0;
    public static int Placed = 0;

    public float DoorSolveHeight;
    private float DoorOrigin;
    public float speed;
    private float T;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        T = Door.transform.position.y;

        if (Relic == 3)
        {
            Flag1 = true;

            Debug.Log("You have all three relics!!!");
        }
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
    }
}
