using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_Detection : MonoBehaviour
{

    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;
    public GameObject crackedEgg1;
    public GameObject crackedEgg2;
    public GameObject crackedEgg3;
    public GameObject rawEggs;
    AudioSource crack;
    
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        crack = this.GetComponent<AudioSource>();
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
            crackedEgg1.transform.position = egg1.transform.position;
            Destroy(egg1);
            crackedEgg1.SetActive(true);
            crack.Play();
        }
        else if(collision.gameObject.name == "Egg_2")
        {
            counter++;
            crackedEgg2.transform.position = egg2.transform.position;
            Destroy(egg2);
            crackedEgg2.SetActive(true);
            crack.Play();
        }
        else if (collision.gameObject.name == "Egg_3")
        {
            counter++;
            crackedEgg3.transform.position = egg3.transform.position;
            Destroy(egg3);
            crackedEgg3.SetActive(true);
            crack.Play();
        }
    }
}
