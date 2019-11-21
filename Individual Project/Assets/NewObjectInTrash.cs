using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewObjectInTrash : MonoBehaviour
{
    public Text text;

    private float spawnDist = 5;

    

    void OnTriggerEnter(Collider collider) 
    {
        if (collider.tag == "Trash")
        {
            
        }
        else
        {
            collider.transform.position = new Vector3(Random.Range(-spawnDist, spawnDist), 10, Random.Range(-spawnDist, spawnDist));
        }
    }
}
