using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStart : MonoBehaviour
{
    private float spawnDist = 5;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(Random.Range(-spawnDist, spawnDist), 10, Random.Range(-spawnDist, spawnDist));
    }
}
