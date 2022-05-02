using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    public Animator transition;
    public float TransitionTime = 1f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        LoadNextLevel();
    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
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
}
