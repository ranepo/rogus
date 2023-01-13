using UnityEngine;
using UnityEngine.UI;

//Use the Selectable class as a base class to access the IsHighlighted method
public class Example : Selectable
{
    void Update()
    {
        //Check if the GameObject is being highlighted
        if (IsHighlighted() == true)
        {
            //Output that the GameObject was highlighted, or do something else
            Debug.Log("Selectable is Highlighted");
        }
    }
}