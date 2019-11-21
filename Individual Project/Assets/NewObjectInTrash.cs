﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewObjectInTrash : MonoBehaviour
{
    public Text displayText;

    private float spawnDist = 5;
    

    void OnTriggerEnter(Collider collider) 
    {
        if (collider.tag == "Trash")
        {
            if (displayText.text.Substring(0,2).Equals("Pu"))
            {
                displayText.text = "1/5";
            }
            else
            {
                int itemsFound = int.Parse(displayText.text.Substring(0, 1));
                if (itemsFound == 5)
                {
                    // you win // you did it
                }
                else
                {
                    displayText.text = itemsFound + "/5";
                }
            }
        }
        else if (collider.tag == "Recyclable")
        {
            collider.transform.position = new Vector3(Random.Range(-spawnDist, spawnDist), 10, Random.Range(-spawnDist, spawnDist));
        }
    }
}
