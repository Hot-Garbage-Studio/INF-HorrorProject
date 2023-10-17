using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Catch : MonoBehaviour
{
   public GameObject aniDeath;


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 8)
        {
            aniDeath.SetActive(true);
            StartCoroutine(Timer());

        }
    }

    IEnumerator Timer(){
        yield return new WaitForSecondsRealtime(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
