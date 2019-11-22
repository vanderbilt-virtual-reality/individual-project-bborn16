using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewObjectInRecycling : MonoBehaviour
{
    public Text displayText;

    private float spawnDist = 5;


    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Recyclable")
        {
            if (displayText.text.Substring(0, 2).Equals("Pu") || displayText.text.Substring(0, 2).Equals("Th"))
            {
                displayText.text = "1/5";
            }
            else
            {
                int itemsFound = int.Parse(displayText.text.Substring(0, 1));
                if (itemsFound == 5)
                {
                    displayText.text = "Thanks for helping clean up!";
                }
                else
                {
                    displayText.text = (itemsFound+1) + "/5";
                }
            }
        }
        else if (collider.tag == "Trash")
        {
            collider.transform.position = new Vector3(Random.Range(-spawnDist, spawnDist), 25, Random.Range(-spawnDist, spawnDist));
        }
    }
}
