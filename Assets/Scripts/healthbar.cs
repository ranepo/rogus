using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthbar : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI text;

    public void SetHealth(float health)
    {
        slider.value = health;
        text.text = Mathf.Round(health).ToString();
    }
    public void damage(float health)
    {
        slider.value = Mathf.Clamp(slider.value - health, 0f, slider.maxValue);
        text.text = Mathf.Round(health).ToString();
    }
    public void giveHealth(float health)
    {
        slider.value = Mathf.Clamp(slider.value + health, 0f, slider.maxValue);
        text.text = Mathf.Round(health).ToString();
    }
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        text.text = Mathf.Round(health).ToString();
    }
    void Update()
    {
        
    }
}
