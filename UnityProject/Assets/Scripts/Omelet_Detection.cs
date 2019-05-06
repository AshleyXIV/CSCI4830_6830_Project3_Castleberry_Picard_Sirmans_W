using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omelet_Detection : MonoBehaviour
{

    public GameObject seasonedScram;
    public GameObject waste;
    public GameObject uncookedOmelet;

    bool pouredMixture = false;



    // Start is called before the first frame update
    void Start()
    {
       waste = GameObject.FindGameObjectWithTag("Pop_Drop_Loc_1");
    }

    // Update is called once per frame
    void Update()
    {
        if (pouredMixture)
        {
            uncookedOmelet.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MegaBowl_Omelette")
        {
            seasonedScram.transform.position = waste.transform.position;
            pouredMixture = true;
        }
    }
    }
