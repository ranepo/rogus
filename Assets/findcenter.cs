using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findcenter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0);
    }
}