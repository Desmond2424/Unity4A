using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This script is executed at the creation of the cube with "Restez chez vous" slogan displayed on it 
public class RotateCube : MonoBehaviour
{
    public float sp_rotSpeed = 10.0f; //Rotation speed (degrees/seconds)
    private float sp_angle = 0.10f; //Angle of rotations arround Y axis

    // Start is called before the first frame update
    void Start()
    {
        //Reset rotation
        sp_angle = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate angle from time elapsed from last frame 
        sp_angle += sp_rotSpeed * Time.deltaTime;

        //Make object rotate 
        this.transform.localRotation = Quaternion.Euler(0.0f, sp_angle, 0.0f);
    }
}