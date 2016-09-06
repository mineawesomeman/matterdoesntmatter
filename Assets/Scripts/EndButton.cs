using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndButton : MonoBehaviour {

    void OnTriggerEnter(Collider collide)
    {

        if (collide.gameObject.tag == "Hot" || collide.gameObject.tag == "Cold")
        {

            SceneManager.LoadScene("Menu");

        }

    }

}
