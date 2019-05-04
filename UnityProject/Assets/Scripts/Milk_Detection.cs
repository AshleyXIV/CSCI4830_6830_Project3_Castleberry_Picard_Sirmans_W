using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milk_Detection : MonoBehaviour
{

    public GameObject milk;
    public GameObject scram;
    public GameObject rawEggs;

    bool milkIn = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (milkIn)
        {
            scram.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Malk")
        {
            Destroy(milk);
            Destroy(rawEggs);
            milkIn = true;
        }
    }
    }
