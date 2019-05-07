using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterCutter : MonoBehaviour
{
    public GameObject waste;
    public GameObject knfie;
    public GameObject cakehalf1;
    public GameObject cakehalf2;


    // Start is called before the first frame update
    void Start()
    {
        waste = GameObject.FindGameObjectWithTag("Pop_Drop_Loc_1");

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "knife_cake")
        {
            cakehalf1.SetActive(true); cakehalf1.transform.position = this.transform.position;
            cakehalf2.SetActive(true); cakehalf2.transform.position = this.transform.position;
            this.transform.position = waste.transform.position;
        }
    }
}
