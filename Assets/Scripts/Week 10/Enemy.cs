using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;

    public float attackSpeed;

    private float attackTimer;

    protected Player player;

    protected NavMeshAgent navAgent;

    [SerializeField]
    protected float aggroRange = 20f;

    protected bool hasSeenPlayer = false;

    protected int patrolPointIndex = 0; //Helps keep count of which point it's at

    [SerializeField] //Allows for protected/private elements to be accessible in the inspector
    protected List<Transform> patrolPoints = new List<Transform>();

    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.SetDestination(patrolPoints[patrolPointIndex].position); //Sets the destination/points for the enemy)
    }

    protected virtual void Update()
    {
        if (hasSeenPlayer == true)
        {
            if (navAgent.remainingDistance < 0.5f) //Enemy has reached the LAST KNOWN location of the player
            {
                if (Vector3.Distance(this.transform.position, player.transform.position) > aggroRange)
                //If player is further than the aggro range...
                {
                    hasSeenPlayer = false; //Enemy no longer sees player, and returns to patrol path.
                    navAgent.isStopped = false;
                }
                else
                {
                    if (IsPlayerInLos() == true)
                    //If player is still WITHIN Line of Sight...
                    {
                        navAgent.SetDestination(player.transform.position);
                        //Enemy sees the player and will continue chasing them.
                        navAgent.isStopped = false;
                        //Allows for the enemy to move
                    }
                    else //If player is out of sight
                    {
                        hasSeenPlayer = false; //Does not see player
                        navAgent.isStopped = false;
                    }
                }
            }

            //If player is within attack range.
            if (Vector3.Distance(this.transform.position, player.transform.position) > attackRange)
            {
                if (IsPlayerInLos() == true)
                //And player is within the LoS
                {
                    navAgent.SetDestination(player.transform.position);
                    navAgent.isStopped = false;
                }

                /* RaycastHit hit;

                Vector3 dir = player.transform.position - this.transform.position;
                dir.Normalize();
                //This gets the direction between the player and enemy, by minusing the player's point from the enemy's point.
                //Normalize helps keep it a normal int (not negative)

                if (Physics.Raycast(this.transform.position, dir, out hit))
                {
                    if (hit.collider.tag == "Player")
                    {
                        navAgent.SetDestination(player.transform.position);
                        navAgent.isStopped = false;
                    }
                }*/
            }
            else //If player is within attack range
            {
                if (IsPlayerInLos() == true) //and player is within LOS...
                {

                    navAgent.isStopped = true; //Stop the nav movement...
                    this.transform.LookAt(player.transform.position); //Keeps looking at player...
                    //Allows for it to turn and look at you when it's stopped

                    attackTimer += Time.deltaTime; //increase attack timer

                    if (attackTimer > attackSpeed) //Once the attack time reaches the attackk speed...
                    {
                        Attack();
                        attackTimer = 0; //Resets the timer to 0
                    }
                }
                else
                {
                    navAgent.isStopped = false;
                }
            }
        }
        else //If player has NOT been seen...
        {
            if (navAgent.remainingDistance < 0.5f) //if the NavAgent reaches its destination
            {
                patrolPointIndex++; //This increases the index from 0 by plus 1 so it will move onto next Patrol Point

                if (patrolPointIndex >= patrolPoints.Count) //checks to see if the index is greater than or equal to 3
                                                            //If it is greater than 3/the max it will reset/start over and loop the patrolpoint
                                                            //Also prevents it from going out of range.
                {
                    patrolPointIndex = 0; //Sets it back at 0 so it doesn't go out of range, and returns to first point.
                }

                navAgent.SetDestination(patrolPoints[patrolPointIndex].position); //Will SetDestination to determined  point.
                navAgent.isStopped = false; //Makes sure it's allowed to move
            }
        }
    }

    protected virtual void Attack()
    {
        player.TakeDamage(attackDamage);
        //Call an animation to attack
        //OR
        //Deal Damage to the Player
    }

    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
    }

    public void Die()
    {
        //Call death animation
        //OR
        //Destroy the object
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            hasSeenPlayer = true;
        }
    }

    public void SeePlayer()
    {
        //The raycast makes it so that the enemy can't "see" us through the walls

        RaycastHit hit;

        Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();

        if (Physics.Raycast(this.transform.position, dir, out hit))
        {
            if (hit.collider.tag == "Player")
            {
                hasSeenPlayer = true;
            }
        }
    }

    protected bool IsPlayerInLos()
    {
        RaycastHit hit;

        Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();
        //This gets the direction between the player and enemy, by minusing the player's point from the enemy's point.
        //Normalize helps keep it a normal int (not negative)

        if (Physics.Raycast(this.transform.position, dir, out hit))
        {
            Debug.Log(hit.collider.name);

            if (hit.collider.tag == "Player")
            {
                return true;
            }
        }
      return false;
    }

}

