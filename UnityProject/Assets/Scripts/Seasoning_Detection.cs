using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seasoning_Detection : MonoBehaviour
{

    public GameObject salt;
    public GameObject pepper;

    public GameObject seasonedScram;
    public GameObject scram;
 

    bool saltIn = false;
    bool pepperIn = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (saltIn && pepperIn)
        {
            seasonedScram.SetActive(true);
            Destroy(scram);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "salt_omlet")
        {
            Destroy(salt);
            saltIn = true;
        }
        if (collision.gameObject.name == "pepper_omlet") {
            Destroy(pepper);
            pepperIn = true;
        }

    }
}
