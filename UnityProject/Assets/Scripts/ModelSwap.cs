using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSwap : MonoBehaviour
{

    
    public GameObject targetFood;
    GameObject waste = GameObject.FindGameObjectWithTag("Pop_Drop_Loc_1");


    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown("s"))
        {

            targetFood.transform.position = transform.position;
            transform.position = waste.transform.position;
        }
    }
}
