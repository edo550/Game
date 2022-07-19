using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    /*
    //private AudioSource finishSound;
    //private bool levelCompleted = false;

    private void Start()
    {
        //finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" )
        {
            //finishSound.Play();
            Destroy(gameObject);
            //levelCompleted = true;
            //Invoke("CompleteLevel", 2f);
        }
    }

    //private void CompleteLevel()
   // {
    //    SceneManager.LoadScene("EndScreen");
   // }
   */

    //public AudioClip fuelSound;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //AudioSource.PlayClipAtPoint(fuelSound, transform.position, 3f);
            FindObjectOfType<audioManager>().Fuel();
            FuelCounterScript.fuelAmount += 20;
            Destroy(gameObject);
        }
    }
}
