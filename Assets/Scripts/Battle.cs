using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    // Update is called once per frame
    public float damage = 20f;

    public float cooldown = 1f;
    float activecooldown;

    void Start()
    {
        activecooldown = cooldown;
    }
    void Update()
    {
        activecooldown -= Time.deltaTime;
        if (activecooldown <= 0f && Time.timeScale == 1f)
            {
                if (Input.GetMouseButton(0))
                {
                activecooldown = cooldown;
                RaycastHit hit;
                Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
                    if (Physics.Raycast(ray, out hit, 3f))
                    {
                        if (hit.transform)
                        {
                            //Debug.Log(hit.transform.gameObject);
                            if (hit.transform.gameObject.tag == "enemy")
                            {
                                hit.transform.gameObject.GetComponent<enemyAI>().takeDamage(damage);
                            }
                        }
                    }
                }
            }
    }
}
