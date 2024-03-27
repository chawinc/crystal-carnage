using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandit_Attack : MonoBehaviour
{
     //Initiate animator attack
    public Animator animator;
    //attack point, create empty object and pair it with the weapon
    public Transform attackPoint;
    //Range of the attack
    public float attackRange = 0.5f;
    //Layer for all enemies
    public LayerMask enemiesLayer;


    // Update is called once per frame
    void Update()
    {
        //attack when player press q key
        if (Input.GetKeyDown(KeyCode.V))    
        {
            Attack();
        }
    }

    //attack function
    void Attack()
    {
        //start the attack animation
        animator.SetTrigger("Attack");

        //create Collider array for range all enemies and make damage. Circle that shows the range of attack  of the weapon
        Collider2D[] attackEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemiesLayer);

        //make damage to all enemies in the attackEnemies variable
        foreach(Collider2D enemy in attackEnemies)
        {
            Debug.Log("Hit!!! " + enemy.name);
        }
    }
    //Reference for radious of attack, this is only to determine the range of attack visually with attack point.
    //void OnDrawGizmanosSelected()
   //{
      //  if (attackPoint == null)
       // return;

     //   Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    //}
}
