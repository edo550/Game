using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public Animator animator;
    public PlayfabManager playfabManager;
    public int appoggio = 0;

    private bool levelCompleted = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted && FuelCounterScript.fuelAmount >= 100)
        {

            FuelCounterScript.fuelAmount -= 100;

            Destroy(collision.gameObject);
            animator.SetBool("Finish", true);
            levelCompleted = true;
            Invoke("CompleteLevel", 4f);
        }
        else
        {
            NotificationManager.Instance.SetNewNotification("No fuel for takeoff");
        }
    }

    private void CompleteLevel()
    {
        TimerController.instance.EndTimer();
        appoggio = CoinCounterScript.coinAmount;
        playfabManager.SubmitScore(appoggio);
        SceneManager.LoadScene("EndScreen");
    }
}
