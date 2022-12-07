using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManag : MonoBehaviour
{
    public PlaySound playSoundScript;



    public void ChangeScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OKButton(int sceneNumber)
    {
        //PLAY AUDIO IN COROUTINE
        StartCoroutine(OK(sceneNumber));
    }

    #region COROUTINES
    IEnumerator OK(int sceneNumb)
    {
        yield return StartCoroutine(PlaySound());
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneNumb);
        yield return null;
    }
    IEnumerator PlaySound()
    {
        playSoundScript.PlayButtonSound();
        yield return null;
    }
    #endregion
}
