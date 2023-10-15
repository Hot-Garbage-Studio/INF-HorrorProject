using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interactible : MonoBehaviour
{
    //1: Scene Change
    //2: Pick-Up
    //3: Door
    //4: Hide
    public int behaviour;
    [SerializeField] private int nextSceneIndex;
    //Either which key to pick up or what key the player needs to open a door;
    [SerializeField] private int whichKeyIndex;
    //used to get the gameobject of player
    static private GameObject player;
    //used to get the actual "player" component
    static private player playerObj;

    public void changeScene()
    {
        SceneManager.LoadScene(nextSceneIndex);

    }
    public void collectPickUp()
    {
        playerObj.pickUpKey(whichKeyIndex);
    }
    public void openDoor()
    {

    }
    public void hide()
    {

    }

    public void getBehaviour()
    {
        if (behaviour == 1)
        {
            changeScene();

        }
        else if (behaviour == 2)
        {
            collectPickUp();
        }
    }

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerObj = player.GetComponent<player>();
    }
}
