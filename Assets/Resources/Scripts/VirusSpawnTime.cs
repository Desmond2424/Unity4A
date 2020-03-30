using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusSpawnTime : MonoBehaviour
{
    public GameObject virusPrefab;

    public float xPos, yPos, zPos;
    public float delay ; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitFor(delay));
    }

    // Update is called once per frame
    void Update()
    {
       

    }

   IEnumerator WaitFor(float delayit)
    {
        
        
        yield return new WaitForSeconds(delayit);
        // GameObject vir = Instantiate(virusPrefab , new Vector3(xPos , yPos , zPos ), Quaternion.identity) as GameObject ;
        Instantiate(virusPrefab) ;
        Instantiate(virusPrefab, new Vector3(xPos, yPos, zPos), Quaternion.identity);
    }
}
