using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interactible : MonoBehaviour
{
    //1: Scene Change
    //2: Pick-Up
    //3: Door
    public int behaviour;
    public int nextSceneIndex;
    public void changeScene()
    {
        SceneManager.LoadScene(nextSceneIndex);

    }

    public void getBehaviour()
    {
        if (behaviour == 1)
        {
            changeScene();
        }
    }

    public void Start()
    {

    }
}
