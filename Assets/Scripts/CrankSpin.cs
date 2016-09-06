using UnityEngine;
using System.Collections;

public class CrankSpin : MonoBehaviour {

   public GameObject crank;
   /*public AudioSource sound;
   public AudioClip clip, clip2, clip3;
   public int random;*/

   void Update ()
    {

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll > 0f || scroll < 0f || Input.GetKey(KeyCode.Q))
        {

            this.gameObject.transform.Rotate(new Vector3(0, 0, -10));

            /*random = Random.Range(1, 4);

            if (random == 1)
            {

                sound.clip = clip;

            }
            if (random == 2)
            {

                sound.clip = clip2;

            }
            if (random == 3)
            {

                sound.clip = clip3;

            }

            sound.clip = clip;
            sound.Play();*/

        }//end cranking to add energy

    }
}
