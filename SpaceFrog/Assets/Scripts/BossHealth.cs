

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{

	public int health = 20;
	//public int currentHealth;
	public Animator animator;
	public GameObject deathEffect;
	private BoxCollider2D bc;

	public bool isInvulnerable = false;

	void Start()
	{
		bc = GetComponent<BoxCollider2D>();

	}

	public void TakeDamage(int damage)
	{
		if (isInvulnerable)
			return;
		Debug.Log("Colpito");
		health -= damage;
		FindObjectOfType<audioManager>().Boss();


		if (health <= 0)
		{
			Die();
		}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Trap"))
		{
			Die();
		}
	}

	void Die()
	{
		bc.isTrigger = true;
		animator.SetTrigger("Death");
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}