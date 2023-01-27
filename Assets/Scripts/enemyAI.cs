using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public Transform player;
    public Material material0;
    public Rigidbody rb;
    public Material material1;
    public float speed;
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material = material0;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(speed*(player.position - transform.position));
        if(transform.position.y<-10)
        {
            Debug.Log("hllo");
            Destroy(self);
        }
    }

}
