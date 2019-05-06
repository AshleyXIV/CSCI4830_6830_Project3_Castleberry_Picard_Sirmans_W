using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_Detection : MonoBehaviour
{

    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;
    public GameObject rawEggs;
    public GameObject waste;
    
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        waste = GameObject.FindGameObjectWithTag("Pop_Drop_Loc_1");
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 3)
        {
            rawEggs.SetActive(true);
        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Egg_1")
        {
            counter++;
            egg1.transform.position = waste.transform.position;
        }else if(collision.gameObject.name == "Egg_2")
        {
            counter++;
            egg2.transform.position = waste.transform.position;
        }
        else if (collision.gameObject.name == "Egg_3")
        {
            counter++;
            egg3.transform.position = waste.transform.position;
        }
    }
}
