using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seasoning_Detection : MonoBehaviour
{

    public GameObject salt;
    public GameObject pepper;
    public GameObject waste;
    public GameObject seasonedScram;
    public GameObject scram;
 

    bool saltIn = false;
    bool pepperIn = false;



    // Start is called before the first frame update
    void Start()
    {
        waste = GameObject.FindGameObjectWithTag("Pop_Drop_Loc_1");
    }

    // Update is called once per frame
    void Update()
    {
        if (saltIn && pepperIn)
        {
            seasonedScram.SetActive(true);
            scram.transform.position = waste.transform.position;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "salt_omlet")
        {
            salt.transform.position = waste.transform.position;
            saltIn = true;
        }
        if (collision.gameObject.name == "pepper_omlet") {
            pepper.transform.position = waste.transform.position;
            pepperIn = true;
        }

    }
}
