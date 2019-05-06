using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milk_Detection : MonoBehaviour
{

    public GameObject milk;
    public GameObject scram;
    public GameObject rawEggs;
    GameObject waste;

    int whiskCounter = 0;
    bool milkIn = false;
    bool stirredNMilky = false;


    // Start is called before the first frame update
    void Start()
    {
        waste = GameObject.FindGameObjectWithTag("Pop_Drop_Loc_1");
    }

    // Update is called once per frame
    void Update()
    {
        if (whiskCounter == 5 && milkIn)
            {
                stirredNMilky = true;
                Debug.Log("Stirred N Milky");
            }
        if (stirredNMilky)
        {
            scram.SetActive(true);
            rawEggs.transform.position = waste.transform.position;

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Malk")
        {
            milk.transform.position = waste.transform.position;
            
            milkIn = true;
            Debug.Log(" Milky");

        }
        if (collision.gameObject.name == "whisk_omlet")
        {
            whiskCounter++;
            Debug.Log("Counter Incrementing = " + whiskCounter);
            
        }

    }
}
