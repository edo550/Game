using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    public int currentHealth;
    //public AudioClip crowSound;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        currentHealth = maxHealth;

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        FindObjectOfType<audioManager>().Crow();
        //Play hurt animation
        //animator.SetTrigger("Hurt");
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died!");

        //Die animation
         //animator.SetBool("IsDead", true);

        //Disable the enemy
        bc.isTrigger = true;
        //rb.bodyType = RigidbodyType2D.Static;
        rb.gravityScale = 10;
        
       // GetComponent<Collider2D>().enabled = false;
        //this.enabled = false;
    }


}
