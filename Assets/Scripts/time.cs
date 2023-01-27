using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class time : MonoBehaviour
{
    public TextMeshProUGUI clock;
    public float currentTime = 10f;
    public GameObject GameManager;

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime>=0)
        {
            clock.text = Mathf.Round(currentTime).ToString();
        }
        else
        {
            GameManager.GetComponent<Scenes>().death();
        }
    }
}
