using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateButtons : MonoBehaviour
{
    public int sceneNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckScene();
        ReturnButton();
    }


    public void ReturnButton()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                if (sceneNumber == 0)
                {
                    Application.Quit();
                }
                else if (sceneNumber == 1)
                {
                    SceneManager.LoadScene(0);
                }
                else if (sceneNumber == 2)
                {
                    SceneManager.LoadScene(0);
                }
                else if (sceneNumber == 3)
                {
                    SceneManager.LoadScene(0);
                }
            }
        }
    }

    public void CheckScene()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            sceneNumber = 0;
        }
        else if (SceneManager.GetActiveScene().name == "Options")
        {
            sceneNumber = 2;
        }
        else if (SceneManager.GetActiveScene().name == "LieDetector")
        {
            sceneNumber = 1;
        }
        else if (SceneManager.GetActiveScene().name == "CardLieDetector")
        {
            sceneNumber = 3;
        }
    }
}
