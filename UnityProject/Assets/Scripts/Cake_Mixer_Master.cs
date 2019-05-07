using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake_Mixer_Master : MonoBehaviour
{

    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;
    public GameObject egg4;
    public GameObject sugarbag;
    public GameObject sugar;
    public GameObject zesty;
    public GameObject salt;
    public GameObject rawEggs;
    public GameObject spoon;
    public GameObject pan;
    public GameObject waste;
    public GameObject bat;
    public GameObject cream;
    public GameObject vanilla_ice;

    public bool beenMixed, canMix, canMix2 = false;
    bool gotEggs, gotSug, gotSalt, gotZest, gotCream, gotVans = false;
    public bool beenSpooned, beenDumped, beenCreamed = false;

    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        waste = GameObject.FindGameObjectWithTag("Pop_Drop_Loc_1");
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 4)
        {
            rawEggs.SetActive(true);
            gotEggs = true;
        }

        if (gotEggs && gotSalt && gotSug && gotZest)
        {
            canMix = true;
        }

        

        if (gotCream && gotVans)
        {
            canMix2 = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Egg_1")
        {
            counter++;
            egg1.GetComponent<AudioSource>().Play();
            egg1.transform.position = waste.transform.position;
        }
        else if (collision.gameObject.name == "Egg_2")
        {
            counter++;
            egg2.GetComponent<AudioSource>().Play();

            egg2.transform.position = waste.transform.position;
        }
        else if (collision.gameObject.name == "Egg_3")
        {
            counter++; egg3.GetComponent<AudioSource>().Play();

            egg3.transform.position = waste.transform.position;
        }
        else if (collision.gameObject.name == "Egg_4")
        {
            counter++;
            egg4.GetComponent<AudioSource>().Play();

            egg4.transform.position = waste.transform.position;
        }
        else if (collision.gameObject.name == "sugarBag")
        {
            gotSug = true;
            sugar.SetActive(true);
        }
        else if (collision.gameObject.name == "Salt")
        {
            gotSalt = true;
        }
        else if (collision.gameObject.name == "lemon_zest")
        {
            gotZest = true;
            zesty.transform.position = this.transform.position;
        }
        else if (collision.gameObject.name == "woodenSpoon" && beenMixed)
        {
            beenSpooned = true;
        }
        else if (collision.gameObject.name == "cakePan" && beenMixed && beenSpooned)
        {
            beenDumped = true;
            bat.transform.position = waste.transform.position;
        }
        else if (collision.gameObject == cream && beenDumped)
        {
            cream.SetActive(true);
        }
        else if (collision.gameObject == vanilla_ice && beenDumped)
        {
            gotVans = true;
        }
    }
}


