using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardController : MonoBehaviour
{
    public InputField score;
    public InputField name;
    public Text textScore, textName;

    
    public Text[] scoreNames;
    public string[] highScoreNames;

    public Text[] highScores;
    public int[] highScoreValues;

    // Start is called before the first frame update
    void Start()
    {
        highScoreValues = new int[highScores.Length];
        highScoreNames = new string[scoreNames.Length];

        for(int i = 0; i < highScores.Length; i++)
        {
            highScoreValues[i] = PlayerPrefs.GetInt("highScoreValues" + i);
            highScoreNames[i] = PlayerPrefs.GetString("highScoreNames" + i);
        }
        DrawScores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveScores()
    {
        for (int i = 0; i < highScores.Length; i++)
        {
            PlayerPrefs.SetInt("highScoreValues" + i, highScoreValues[i]);
            PlayerPrefs.SetString("highScoreNames" + i, highScoreNames[i]);

        }
    }

    public void CheckHighScore(int value, string userName)
    {
        for(int i = 0; i < highScores.Length; i++)
        {
            if(value > highScoreValues[i])
            {
                for(int j = highScoreValues.Length - 1; j > i; j--)
                {
                    highScoreValues[j] = highScoreValues[j - 1];
                    highScoreNames[j] = highScoreNames[j - 1];
                }
                highScoreValues[i] = value;
                highScoreNames[i] = userName;
                DrawScores();
                SaveScores();
                break;
            }
        }
    }

    public void DrawScores()
    {
        for (int i = 0; i < highScores.Length; i++)
        {
            highScores[i].text = highScoreValues[i].ToString();
            scoreNames[i].text = highScoreNames[i];
        }
    }

    public void ChangeScoreTest()
    {
        //textScore.text = score.text;
        textName.text = name.text + ": ";

        int scoreValue = int.Parse(score.text);

        CheckHighScore(scoreValue, name.text);
    }

    public void ResetScores()
    {
        PlayerPrefs.DeleteAll();
        for (int i = 0; i < highScores.Length; i++)
        {
            highScoreValues[i] = PlayerPrefs.GetInt("highScoreValues" + i);
            highScoreNames[i] = PlayerPrefs.GetString("highScoreNames" + i);
        }
        DrawScores();
    }

}
