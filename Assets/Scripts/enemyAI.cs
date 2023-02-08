using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    public GameObject Player;
    public Transform player;
    public Rigidbody rb;
    public GameObject self;
    public NavMeshAgent agent;
    public float cooldown = 1f;
    float activecooldown;
    public float distance = 4f;
    float health;
    public float maxHealth = 100f;
    public Material basemat;
    public Material damagemat;

    void Start()
    {
        //player = GameObject.Find("paketti/player");
        //Debug.Log(player);
        activecooldown = cooldown;
        agent.isStopped = false;
        health = maxHealth;
        GetComponent<Renderer>().material = basemat;
    }

    void Update()
    {
        //Debug.Log(activecooldown);
        activecooldown -= Time.deltaTime;
        agent.SetDestination(player.position);
        if (activecooldown <= 0f)
        {
            GetComponent<Renderer>().material = basemat;
            //Debug.Log(Vector3.Distance(transform.position, player.position));
            agent.isStopped = false;
            if (Vector3.Distance(transform.position, player.position)<distance)
            {
                attack();
                agent.isStopped = true;
                activecooldown = cooldown;
            }
        }
        if (health <= 0f)
        {
            Destroy(self);
        }
    }
    public void attack()
    {
        Player.GetComponent<health>().takeDamage(10f);
    }
    public void takeDamage(float amount)
    {
        health -= amount;
        Debug.Log(health);
        GetComponent<Renderer>().material = damagemat;
        activecooldown = cooldown;
    }

}
