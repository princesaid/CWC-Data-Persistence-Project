using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI playerNameInput;
    public TextMeshProUGUI playerName;

    public string playerHighScore;

    [SerializeField] private TextMeshProUGUI highScore;

    //[SerializeField] private GameObject highScore;
    // Start is called before the first frame update
    void Start()
    {
        if (MainManager.Instance != null)
        {

            playerName.text = MainManager.Instance.playerName;

        }
        HighScore();
        MainManager.Instance.LoadData();


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNew()
    {

        MainManager.Instance.playerName = playerNameInput.text;
        SceneManager.LoadScene("Main");

    }

    public void Exit()
    {
        EditorApplication.ExitPlaymode();
        Application.Quit();
        MainManager.Instance.SaveHighScore();
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
        MainManager.Instance.SaveHighScore();
    }
    public void HighScore()
    {
        if (MainManager.Instance.highScore != 0)
        {

            highScore.text = "HighScore: " + MainManager.Instance.highScorePlayer + " | " + MainManager.Instance.highScore;

        }
    }
}
