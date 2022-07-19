using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader1 : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;


    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            // Touch touch =
            Input.GetTouch(0);
           // Vector3 touchPosition = camera.main.ScreenToWorldPoint(touch.position);
            
           // touchPosition z = 0f;
           // trasform.position = touchPosition;
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Game 2");
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");


        yield return new WaitForSeconds(transitionTime);


        SceneManager.LoadScene(levelIndex);
    }
    
}
