using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{

    void OnTriggerEnter(Collider collide)
    {

        //Debug.Log("Hit");
        Destroy(gameObject);

    }
	
}
