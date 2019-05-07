using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeHalf : MonoBehaviour
{
    public GameObject cream;
    public GameObject waste;
    public GameObject newhalf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "theCoolerWhippedCream")
        {
            newhalf.SetActive(true); newhalf.transform.position = this.transform.position;
            this.transform.position = waste.transform.position;
        }
    }
}
