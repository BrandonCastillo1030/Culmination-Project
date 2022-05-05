using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    public float TransitionTime = 1f;
    public Button PlayButton;
    public Button QuitButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Play()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void Exit() 
    {
    Application.Quit();
    }
    IEnumerator LoadLevel(int LevelIndex)
    {
        //play animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(TransitionTime);

        //load scene

        SceneManager.LoadScene(LevelIndex);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (GameManager.Flag5==true)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
    }
}

