using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public bool[] keys;

    public void pickUpKey(int keyIndex)
    {
        keys[keyIndex] = true;
    }

}

