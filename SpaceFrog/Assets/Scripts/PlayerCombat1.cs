using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat1 : MonoBehaviour
{

    public Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    
    public float attackRange = 0.5f;
    public int attackDamage = 50;

    public float attackRate = 2f;
    float nextAttackTime = 0f;

    // Update is called once per frame
    public void Kick()
    {
        if(Time.time >= nextAttackTime)
        {   
                Attack();       
                nextAttackTime = Time.time + 1f / attackRate;
        }

        void Attack()
        {  
            //Play an attack animation
            animator.SetTrigger("Attack");

            //Detect enemies in range of attack
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

            //Damage them
            foreach(Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Enemy>().TakeDamage(attackDamage); 
            }
        }
        
        void OnDrawGizmosSelected()
        {
            if (attackPoint == null)
                return;

            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }
    }
    public void KickUp()
    {
        attackDamage += 5;
    }
}
