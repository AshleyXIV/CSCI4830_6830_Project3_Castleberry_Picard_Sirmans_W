using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omelet_Detection : MonoBehaviour
{

    public GameObject seasonedScram;
    public GameObject megaBowl;
    public GameObject uncookedOmelet;

    bool pouredMixture = false;



    // Start is called before the first frame update
    void Start()
    {
        
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
        if (collision.gameObject.name == "megaBowl")
        {
            Destroy(seasonedScram);
            pouredMixture = true;
        }
    }
    }
