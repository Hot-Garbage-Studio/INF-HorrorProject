using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class interaction : MonoBehaviour
{
    [HideInInspector] public bool canInteract = false;


    void Update()
    {
        if (canInteract && Input.GetButtonDown("Submit"))
        {
            Debug.Log("Interacted");
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 6)
        {
            canInteract = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.layer == 6)
        {
            canInteract = false;
        }
    }
}
