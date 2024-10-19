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
    // Start is called before the first frame update
    void Start()
    {
        if (MainManager.Instance != null){

            playerName.text = MainManager.Instance.playerName;

        }

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
    }
    public void MenuButton(){
        SceneManager.LoadScene("Menu");
    }
}
