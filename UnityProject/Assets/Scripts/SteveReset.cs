using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SteveReset : MonoBehaviour
{
    public GameObject steve;
    public GameObject omelette;
    public GameObject waste;

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
        if (collision.gameObject.name == "finishedOmelet")
        {
            omelette.transform.position = waste.transform.position;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }

}
