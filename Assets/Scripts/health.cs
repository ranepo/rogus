using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    // Start is called before the first frame update
    public float currentHealth;
    public int maxHealth = 100;
    public GameObject Bar;
    public GameObject SceneManager;

    void Start()
    {
        currentHealth = maxHealth;
        Bar.GetComponent<healthbar>().SetMaxHealth(maxHealth);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag  == "enemy")
        {
            takeDamage(20f);
        }
    }
    void takeDamage(float damage)
    {
        currentHealth -= damage;
        Bar.GetComponent<healthbar>().SetHealth(currentHealth);
    }
    void Update()
    {
        if (currentHealth <= 0)
        {
            SceneManager.GetComponent<Scenes>().death();
        } 
    }
}
