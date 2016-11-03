using UnityEngine;
using System.Collections;

public class CrankSpin : MonoBehaviour {

   public GameObject crank; //When is this used?!?!?!
	
   void Update ()
    {

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll > 0f || scroll < 0f || Input.GetKey(KeyCode.Q)) //Why is scroll used here and at Shooting.cs ?
        {

            this.gameObject.transform.Rotate(new Vector3(0, 0, -10)); //Rotating? What For?

        }//end cranking to add energy

    }
}
