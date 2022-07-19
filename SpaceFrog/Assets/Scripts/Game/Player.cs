using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;
	private Rigidbody2D rb;
	public HealthBar healthBar;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	// Update is called once per frame
	void Update()
	{
        if (currentHealth <= 0)
        {
			Die();
			RestartLevel();
		}

		//if (Input.GetKeyDown(KeyCode.Space))
		//{
		//	TakeDamage(20);
		//}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Enemy"))
		{
			TakeDamage(20);
		}
	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	private void Die()
	{
		//deathSoundEffect.Play();
		rb.bodyType = RigidbodyType2D.Static;
		//anim.SetTrigger("death");
		RestartLevel();
	}

	private void RestartLevel()
	{
		FindObjectOfType<GameOver>().Game();
		//Time.timeScale = 1f;
		//SceneManager.LoadScene("Game");
	}

	public void LifeUp()
    {
		maxHealth += 10;
    }
}