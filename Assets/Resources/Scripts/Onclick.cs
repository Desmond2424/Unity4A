using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onclick : MonoBehaviour
{
    public GameObject Prefab;
    public int RayDistance = 10;
    private Vector3 Point;
    public LayerMask Layer;

    public GameObject virus;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Make Whatever a Raycast layer or if you don't want it just exclude it
            if (Physics.Raycast(ray, out hit, Layer.value))
            {
                Point = hit.point;
                Instantiate(virus, Point, Quaternion.identity);
            }
        }*/
    }

    private void OnMouseDown()
    {
        ;
        for(int i = 0; i<5; i++)
        {
            for(int j = 0; j <5; j++)
            {
                Instantiate(virus, new Vector3(i, j, 1), Quaternion.identity);
            }
        }
       
    }
}
