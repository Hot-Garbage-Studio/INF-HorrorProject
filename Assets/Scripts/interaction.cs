using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class interaction : MonoBehaviour
{
    public bool canInteract = false;


    void Update()
    {
        if (canInteract && Input.GetButtonDown("Submit"))
        {
            Debug.Log("Interacted");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            canInteract = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            canInteract = false;
        }
    }
}
