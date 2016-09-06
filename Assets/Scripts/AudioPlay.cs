using UnityEngine;
using System.Collections;

public class AudioPlay : MonoBehaviour
{

    public AudioSource sound;

    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.tag == "Player")
        {
            sound.Play();
            Destroy(this);
        }
        
    }

}
