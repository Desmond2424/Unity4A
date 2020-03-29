using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{

    public Rigidbody projectile;
    public Transform origine;
    public int force = 50;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touch_Pos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch_Pos.x > 0)
            {
                Rigidbody instance;
                instance = Instantiate(projectile, origine.position, origine.rotation) as Rigidbody;
                instance.AddForce(origine.forward * force);
            }
        }
    }
}
