using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Solved : MonoBehaviour
{
    public GameObject Pillar1;
    public GameObject Pillar2;
    public GameObject Pillar3;
    public GameObject Pillar4;
    public GameObject Door;
    public int SolveMax;
    public int SolveMin;
    private bool Solved1 = false;
    private bool Solved2 = false;
    private bool Solved3 = false;
    private bool Solved4 = false;
    public float speed;
    public float DoorSolveHeight;
    private float DoorOrigin;

    private void Start()
    {
        DoorOrigin = Door.transform.position.y;
    }
    void Update()
    {

        // Registers GameObjects rotation to a value
        float T = Door.transform.position.y;
        float P1 = Pillar1.transform.localEulerAngles.y;
        float P2 = Pillar2.transform.localEulerAngles.y;
        float P3 = Pillar3.transform.localEulerAngles.y;
        float P4 = Pillar4.transform.localEulerAngles.y;
        Debug.Log("P1: "+ P1 + " P2: " + P2 + " P3: " + P3 + " P4: " + P4 );

        //Checks to see if game object rotation is between 2 values
        if (P1 >= SolveMin && P1<= SolveMax && P2 >= SolveMin && P2 <= SolveMax && 
            P3 >= SolveMin && P3 <= SolveMax && P4 >= SolveMin && P4 <= SolveMax) 
        {
            Solved1 = true; 
            Solved2 = true; 
            Solved3 = true;
            Solved4 = true;
        }
        else
        {
            Solved1 = false;
            Solved2 = false;
            Solved3 = false;
            Solved4 = false;
        }

         if (Solved1 == true && Solved2 == true && Solved3 == true && Solved4 == true)
        {
            GameManager.Flag3 = true;
            Debug.Log("Solved!");
            if (T <= DoorSolveHeight)
            {
                Door.transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
            }

        }
        else
        {
            if(T > DoorOrigin)
            {
                Door.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            }
           
        }
    }
}
