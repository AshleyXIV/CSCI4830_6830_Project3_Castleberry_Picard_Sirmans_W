using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        loadlevel("chickenParmLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
