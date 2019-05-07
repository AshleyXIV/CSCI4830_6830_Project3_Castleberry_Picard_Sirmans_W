using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("["))
        {
            SceneManager.LoadScene("chickenParmLevel");
        }
        if (Input.GetKeyDown("]"))
        {
            SceneManager.LoadScene("omeletteLevel");
        }
        if (Input.GetKeyDown(";"))
        {
            SceneManager.LoadScene("chickenParmLevel");
        }
        if (Input.GetKeyDown("/"))
        {
            SceneManager.LoadScene("LeaderboardFix");
        }
    }

    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
