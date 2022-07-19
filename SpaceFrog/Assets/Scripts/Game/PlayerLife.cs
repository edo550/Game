using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    //public CoinCounterScript cs;
    public PlayfabManager playfabManager;
    public int appoggio = 0;
    //public int maxMoney;
    private Rigidbody2D rb;
    private Animator anim;
    
    

    [SerializeField] private AudioSource deathSoundEffect;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            
            Die();
            RestartLevel();
        }
    }

    private void Die()
    { 
        //deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
        Debug.Log("funziona");
        appoggio = CoinCounterScript.coinAmount;
        playfabManager.SubmitScore(appoggio);
        CoinCounterScript.coinAmount = 0;
        FuelCounterScript.fuelAmount = 0;

    }

    private void RestartLevel()
    {
        FindObjectOfType<GameOver>().Game();
        //SceneManager.LoadScene("Game");
    }
}
