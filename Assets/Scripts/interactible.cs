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
    [SerializeField] private bool isDoorLocked;
    private bool isHidden;
    //used to get the gameobject of player
    public GameObject playerHidden;
    [SerializeField] static private GameObject playerObj;
    //used to get the actual "player" component
    static private player player;

    public void changeScene()
    {
        SceneManager.LoadScene(nextSceneIndex);

    }
    public void collectPickUp()
    {
        player.pickUpKey(whichKeyIndex);
        Destroy(this.gameObject);
    }
    public void openDoor()
    {
        if (!isDoorLocked)
        {

        }
    }
    public void hide()
    {
        if (!isHidden)
        {
            playerHidden.transform.position = playerObj.transform.position;
            playerObj.SetActive(false);
            isHidden = true;
        }
        else
        {
            playerObj.SetActive(true);
            playerHidden.transform.position = new Vector3(0f, -1f, 0f);
            isHidden = false;
        }
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
        else if (behaviour == 3)
        {

        }
        else if (behaviour == 4)
        {
            hide();
        }
        else
        {
            Debug.Log("Invalid Behaviour Set");
        }

    }

    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        playerHidden = GameObject.FindGameObjectWithTag("HiddenPlayer");
        player = playerObj.GetComponent<player>();
    }
}
