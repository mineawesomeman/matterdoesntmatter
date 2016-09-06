using UnityEngine;
using System.Collections;

public class VerticalIce : MonoBehaviour
{

    public int heat; //Amount of energy/heat the object has. Each left click hot projectile from the gun adds 10 heat. Right click cold projectiles removes 10 heat.
    public GameObject ice;
    public GameObject water;

    void OnTriggerEnter(Collider collide)
    {

        if (collide.gameObject.tag == "Hot") //hot projectile
        {

            if (heat < 500)
            {

                heat += 10;
                Debug.Log("Heat Value: " + heat);
                transform.localScale -= new Vector3(0, 0, 0.02F);
                transform.localPosition -= new Vector3(0, 0.025F, 0);

            }

            if (heat == 450 && gameObject.tag == "Ice")
            {

                Destroy(gameObject);
                Instantiate(water, new Vector3(transform.position.x, 0, transform.position.z), transform.rotation);
                Heat waterObject = water.GetComponent<Heat>(); //gets water object and assigns it to waterObject 

            }

        }

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
                Instantiate(ice, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
                Heat iceObject = ice.GetComponent<Heat>(); //gets ice object and assigns it to iceObject

            }

        }

    }

}