using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform origine;
    public int force = 50;

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Hello");

            Rigidbody instance;
            instance = Instantiate(projectile, origine.position, origine.rotation) as Rigidbody;
            instance.AddForce(origine.forward * force);
        }*/

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            Rigidbody instance;
            instance = Instantiate(projectile, origine.position, origine.rotation) as Rigidbody;
            instance.AddForce(origine.forward * force);
        }
    }
}
       