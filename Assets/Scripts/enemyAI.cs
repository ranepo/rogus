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

    void Start()
    {
        //player = GameObject.Find("paketti/player");
        //Debug.Log(player);
        activecooldown = cooldown;
        agent.isStopped = false;
    }

    void Update()
    {
        //Debug.Log(activecooldown);
        activecooldown -= Time.deltaTime;
        agent.SetDestination(player.position);
        if (activecooldown <= 0f)
        {
            Debug.Log(Vector3.Distance(transform.position, player.position));
            agent.isStopped = false;
            if (Vector3.Distance(transform.position, player.position)<3f)
            {
                attack();
                agent.isStopped = true;
                activecooldown = cooldown;
            }
        }
    }
    public void attack()
    {
        Player.GetComponent<health>().takeDamage(10f);
    }

}
