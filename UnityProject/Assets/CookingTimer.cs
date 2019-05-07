using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingTimer : MonoBehaviour
{
    public GameObject waste;
    public GameObject finishedOmelet;
    public GameObject uncookedOmelet;
    public AudioClip sizzle;
    public AudioSource source;

    bool startCount = false;

    float timeLeft = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        waste = GameObject.FindGameObjectWithTag("Pop_Drop_Loc_1");
        source.clip = sizzle;
    }

    
    // Update is called once per frame
    void Update()
    {
        if (startCount)
        {           
            timeLeft -= Time.deltaTime;
            source.Play();
            if (timeLeft <= 0)
            {
                finishedOmelet.SetActive(true);
                uncookedOmelet.transform.position = waste.transform.position;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MegaBowl_Omelette")
        {
            Debug.Log("Omelette should be cooking");
            startCount = true;
            Debug.Log("count started");
        }
    }
}
