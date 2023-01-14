using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sensitivityslider : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener((v) => { GameObject.FindObjectOfType<PlayerCam>().sensitivity = 1600*v; Debug.Log(1600*v); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
