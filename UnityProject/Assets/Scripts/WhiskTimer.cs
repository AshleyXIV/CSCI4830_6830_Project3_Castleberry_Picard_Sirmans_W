using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiskTimer : MonoBehaviour
{
    public GameObject waste;
    public GameObject whisk;
    public GameObject bowl;

    bool startCount;

    float timeLeft = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        waste = GameObject.FindGameObjectWithTag("Pop_Drop_Loc_1");
    }

    // Update is called once per frame
    void Update()
    {
        if (startCount)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                
                
            }
        }
    }
}
