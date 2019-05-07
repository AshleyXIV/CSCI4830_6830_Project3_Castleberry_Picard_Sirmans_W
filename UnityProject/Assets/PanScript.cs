using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanScript : MonoBehaviour
{
    public GameObject panflour;
    public GameObject spray;
    public GameObject mixbowl;
    public GameObject panBatter;
    public GameObject bakedbart;

    public bool sprayed = false;
    public bool flourd = false;
    public bool gotBatter = false;
    public bool isBaked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flourd)
        {
            panflour.SetActive(true);
            flourd = false;
        }

        if (isBaked)
        {
            bakedbart.GetComponent<OVRGrabbable>().enabled = true;
            bakedbart.GetComponent<MeshCollider>().enabled = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "flourBag" && sprayed)
        {
            flourd = true;
            sprayed = false;
        }
        else if (collision.gameObject.name == "sprayBottle")
        {
            sprayed = true;
        }
        else if (collision.gameObject == mixbowl && mixbowl.GetComponent<Cake_Mixer_Master>().beenSpooned)
        {
            gotBatter = true;
            Destroy(panflour);
            panBatter.SetActive(true);
            mixbowl.GetComponent<Cake_Mixer_Master>().beenDumped = true;
        }
    }
}
