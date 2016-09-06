using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Shooting : MonoBehaviour
{

	public int energy = 1000; //total amount of energy the gun has
    public GameObject hotProjectilePrefab;
    public GameObject coldProjectilePrefab;
    public float fireRate = 0.1F;
    public float nextFire = 0.0F;
    public Text hud;

    void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        // Hide cursor when locking
        Cursor.visible = false;
        
    }

    void Update ()
    { 

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadScene("Menu");

        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if ( (scroll > 0f || scroll < 0f) && !Input.GetKey(KeyCode.Q) && energy < 1000)
        {

            energy += 2;
            //Debug.Log("Energy: " + energy);

        }//end mwheel to add energy

        if (Input.GetKey(KeyCode.Q) && energy < 1000)
        {

            energy += 1;
            //Debug.Log("Energy: " + energy);

        }//end q to add energy

        if (energy >= 10)
		{

			if(Input.GetMouseButton(0) && Time.time > nextFire)
			{

                nextFire = Time.time + fireRate;
				GameObject projectile = (GameObject) Instantiate(hotProjectilePrefab, transform.position + Camera.main.transform.forward, transform.rotation);
				Rigidbody rb = projectile.GetComponent<Rigidbody>();
				rb.velocity = Camera.main.transform.forward * 100;
                energy -= 10;
                //Debug.Log("Energy: " + energy);
				
			}//end mouse0 hot projectiles

            if (Input.GetMouseButton(1) && Time.time > nextFire)
            {

                nextFire = Time.time + fireRate;
                GameObject projectile = (GameObject)Instantiate(coldProjectilePrefab, transform.position + Camera.main.transform.forward, transform.rotation);
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = Camera.main.transform.forward * 100;
                energy -= 10;
                //Debug.Log("Energy: " + energy);

            }//end mouse1 cold projectiles

        }//end if energy

        hud.text = "ENERGY: " + energy;

    }

}
