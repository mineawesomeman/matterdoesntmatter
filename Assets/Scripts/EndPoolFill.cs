using UnityEngine;
using System.Collections;

public class EndPoolFill : MonoBehaviour {

    public int heat = 0;
    public GameObject ice;
    public GameObject pool;
    
	void OnTriggerEnter(Collider collide)
    {

            if (collide.gameObject.tag == "Hot") //hot projectile
            {

                if (heat < 500)
                {

                    heat += 10;
                    Debug.Log("Heat Value: " + heat);
                    transform.localScale -= new Vector3(0, 0, 0.015F);
                    transform.localPosition -= new Vector3(0, 0.025F, 0);

                }

                if (heat == 450 && gameObject.tag == "Ice")
                {

                    Destroy(gameObject);
                    pool.transform.localPosition += new Vector3(0, 1F, 0);


                }

            }

    }

}
