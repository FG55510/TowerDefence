using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerButton : MonoBehaviour
{
    public Button myButton;
    public bool check;

    void Start()
    {
        // Disable the button initially
        myButton.interactable = false;
        check = false;
    }

    void Update()
    {
        // Check the condition
        if (check)
        {
            // Enable the button if the condition is met
            myButton.interactable = true;
        }
        else
        {
            // Disable the button if the condition is not met
            myButton.interactable = false;
        }
    }
}
