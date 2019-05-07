using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixerTimer : MonoBehaviour
{
    public GameObject waste;
    public GameObject batter;
    public GameObject zeest;
    public GameObject eggos;
    public GameObject asugar;
    public GameObject bowl;
    public Cake_Mixer_Master yeet;
    public GameObject bigcream;
    public GameObject litllecream;

    bool startCount = false;

    float timeLeft = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        waste = GameObject.FindGameObjectWithTag("Pop_Drop_Loc_1");
    }


    // Update is called once per frame
    void Update()
    {


        if (yeet.canMix == true)
        {

            Debug.Log("shpuld be mixing");
            startCount = true;
            Debug.Log("count started");
        }

        if (yeet.canMix2 == true)
        {

            Debug.Log("shpuld be mixing");
            timeLeft = 10.0f;
            startCount = true;
            Debug.Log("count started");
        }
            
            if (startCount)
        {
            timeLeft -= Time.deltaTime;
            this.GetComponent<AudioSource>().Play();
            if (timeLeft <= 0)
            {
                this.GetComponent<AudioSource>().Play();
                startCount = false;
                if (yeet.canMix2 == true)
                {
                    bigcream.SetActive(true);
                    litllecream.transform.position = waste.transform.position;
                    yeet.canMix2 = false;
                    yeet.beenCreamed = true;
                }
                else
                {
                    batter.SetActive(true);
                    zeest.transform.position = waste.transform.position;
                    eggos.transform.position = waste.transform.position;
                    yeet.canMix = false;
                    yeet.beenMixed = true;
                    asugar.transform.position = waste.transform.position;
                }

            }
        }
    }

    

}
