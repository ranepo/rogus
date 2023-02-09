using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;

    public void SetHealth(float health)
    {
        slider.value = health;
    }
    public void damage(float health)
    {
        slider.value = Mathf.Clamp(slider.value - health, 0f, slider.maxValue);
    }
    public void giveHealth(float health)
    {
        slider.value = Mathf.Clamp(slider.value + health, 0f, slider.maxValue);
    }
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
    }
}
