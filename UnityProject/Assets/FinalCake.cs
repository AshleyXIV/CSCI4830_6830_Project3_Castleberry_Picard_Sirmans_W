using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCake : MonoBehaviour
{
    public GameObject otherguy;
    public GameObject waste;
    public GameObject uh;
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
        if (collision.gameObject.name == "cake_half_with_whippedcream2")
        {
            uh.SetActive(true); uh.transform.position = this.transform.position;
            this.transform.position = waste.transform.position;
            otherguy.transform.position = waste.transform.position;

        }
    }
}
