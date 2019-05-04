using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_Detection : MonoBehaviour
{

    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;
    public GameObject rawEggs;
    
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Counter = " + counter);
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
            Destroy(egg1);
        }else if(collision.gameObject.name == "Egg_2")
        {
            counter++;
            Destroy(egg2);
        }
        else if (collision.gameObject.name == "Egg_3")
        {
            counter++;
            Destroy(egg3);
        }
    }
}
