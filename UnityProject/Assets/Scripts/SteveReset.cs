using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SteveReset : MonoBehaviour
{
    public GameObject steve;
    public GameObject omelette;

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
        if (collision.gameObject.name == "finishedOmelet")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }

}
