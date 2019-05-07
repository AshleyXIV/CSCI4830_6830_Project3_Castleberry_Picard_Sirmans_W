using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeBakeTimer : MonoBehaviour
{
    public GameObject waste;
    public GameObject batter;
    public GameObject baked;
    public PanScript pan;
    public AudioSource ding;

    bool startCount = false;

    float timeLeft = 40.0f;

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
            if (!this.GetComponent<AudioSource>().isPlaying) { this.GetComponent<AudioSource>().Play(); }
            if (timeLeft <= 0)
            {
                this.GetComponent<AudioSource>().Stop();
                startCount = false;
                ding.Play();
                baked.SetActive(true);
                batter.transform.position = waste.transform.position;
                pan.isBaked = true;
                
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "cakePan" && pan.gotBatter == true)
        {
            Debug.Log("shpuld be baking");
            startCount = true;
            Debug.Log("count started");
        }
    }
}
