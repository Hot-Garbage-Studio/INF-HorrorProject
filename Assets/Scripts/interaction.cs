
using UnityEngine;


public class interaction : MonoBehaviour
{
    public bool canInteract = false;
    static interactible nullInteraction;
    private interactible interactionObj = nullInteraction;

    void Update()
    {
        if (canInteract && Input.GetButtonDown("Submit"))
        {
            interactionObj.getBehaviour();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            canInteract = true;
            interactionObj = other.GetComponent<interactible>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            canInteract = false;
            interactionObj = nullInteraction;
        }
    }
}
