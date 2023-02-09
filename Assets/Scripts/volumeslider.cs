using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeslider : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;
        slider.onValueChanged.AddListener((v) => { AudioListener.volume = v; Debug.Log(v); });
    }

}
