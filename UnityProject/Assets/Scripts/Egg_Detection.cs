using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_Detection : MonoBehaviour
{

    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;

    
    GameObject waste;
    Collider col;
    

    bool cracked1 = false;
    bool cracked2 = false;
    bool cracked3 = false;
    bool stacked1 = false;
    bool stacked2 = false;
    bool stacked3 = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject waste = GameObject.FindGameObjectWithTag("Pop_Drop_Loc_1");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stacked1 && cracked1)
        {
            egg1.transform.position = waste.transform.position;
        }
        if (stacked2 && cracked2)
        {
            Debug.Log("Egg 2 has been yeeted");
            egg2.transform.position = waste.transform.position;
        }
        if (stacked3 && cracked3)
        {
            egg3.transform.position = waste.transform.position;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "eggs_1")
        {
            Destroy(egg2);
        }
    }
}
