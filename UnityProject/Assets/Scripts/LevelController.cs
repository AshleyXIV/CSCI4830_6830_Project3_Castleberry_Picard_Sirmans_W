using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEngine.EventSystems;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonClickedOmelette()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        string level = "Level: Omelette";
        Debug.Log(level);

        //PlayerPrefs.SetString("level", level);
    }

    public void buttonClickedChickenParm()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        string level = "Level: Chicken Parm";
        Debug.Log(level);

        //PlayerPrefs.SetString("level", level);
    }

    public void buttonClickedCake()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
        string level = "Level: Cake";
        Debug.Log(level);

        //PlayerPrefs.SetString("level2", level);
    }

    public void buttonClickedLeaderBoard()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
        string level = "Level: Leaderboard";
        Debug.Log(level);
    }
    
}
