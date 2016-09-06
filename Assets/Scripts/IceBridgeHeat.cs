using UnityEngine;
using System.Collections;

public class IceBridgeHeat : MonoBehaviour
{

    public int heat; //Amount of energy/heat the object has. Each left click hot projectile from the gun adds 10 heat. Right click cold projectiles removes 10 heat.
    public GameObject ice;
    public GameObject water;

    void OnTriggerEnter(Collider collide)
    {

        if (collide.gameObject.tag == "Cold") //cold projectile
        {

            if (heat > -100)
            {

                heat -= 10;
                Debug.Log("Heat Value: " + heat);
                //transform.localScale += new Vector3(0.05F, 0, 0);
                //transform.localPosition += new Vector3(0, 0.02F, 0);

            }

            if (heat == 0 && gameObject.tag == "Water")
            {

                Destroy(gameObject);
                Instantiate(ice, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(270, 90, 0));
                Heat iceObject = ice.GetComponent<Heat>(); //gets ice object and assigns it to iceObject

            }

        }

    }

}
