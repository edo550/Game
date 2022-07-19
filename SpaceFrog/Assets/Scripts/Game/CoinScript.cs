using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    //public AudioClip coinSound;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //AudioSource.PlayClipAtPoint(coinSound, transform.position, 4f);
            FindObjectOfType<audioManager>().Coin();
            CoinCounterScript.coinAmount += 1;
            //CoinCounterScript.ca += 1;
            Destroy(gameObject);
        }
    }
    /*
    public void touch(string name)
    {
        int platform = int.Parse(name.Substring(1));
        if(platform +1 > maxPlatform)
        {
            maxPlatform = platform + 1;
            score.text = maxPlatform.ToString();
        }if(platform >= next)
        {
            next += 10;

        }
    }
    */
}
