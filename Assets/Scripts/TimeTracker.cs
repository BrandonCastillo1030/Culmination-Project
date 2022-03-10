using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTracker : MonoBehaviour
{
    public Text text;
    private float Timer = 1;

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        text.text = Timer.ToString();
    }
}
