using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class CamVideos : MonoBehaviour
{
    #region variables
    public OnButtonDown buttonHoldScript;
    public SceneManag sceneManage;
    public VideoPlayer[] vidArray;
    public GameObject firstButton;
    public GameObject secondButton;
    Button btn1;
    Button btn2;
    Button.ButtonClickedEvent onClick;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        PowerOnIsOn();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (VideoPlayer vp in vidArray)
        {           
            if (vp == vidArray[0])
            {
                if (vp.isPlaying == true)
                {
                    btn1.onClick.AddListener(ChangeToStandBy);
                }
            }
            if (vp == vidArray[3])
            {
               if (vp.isPlaying == true)
               {
                    if (vp.time <= 9)
                    {
                        if (buttonHoldScript.isDown)
                        {
                            ChangeToFalse();
                            buttonHoldScript.isDown = false;
                        }                      
                    }
                    else
                    {
                        if (buttonHoldScript.isDown)
                        {
                            ChangeToTrue();
                            buttonHoldScript.isDown = false;
                        }
                    }
               }               
            }
        }
    }

    public void ChangeToStandBy()
    {
        firstButton.SetActive(false);
        secondButton.SetActive(true);
        foreach (VideoPlayer vp in vidArray)
        {
            if (vp == vidArray[3])
            {
                vp.Play();
                vp.isLooping = true;
            }
            else
            {
                vp.Pause();
                vp.Stop();
            }
        }
    }

    public void ChangeToTrue()
    {
        secondButton.SetActive(false);
        foreach (VideoPlayer vp in vidArray)
        {
            if (vp == vidArray[2])
            {
                vp.Play();
                vp.isLooping = false;
                //if song ends.... ChangeToStandBy
                float vpLength = (float)vidArray[2].clip.length;
                Invoke("ChangeToStandBy", vpLength);
            }
            else if (vp == vidArray[3])
            {
                vp.time = 0.1f;
                vp.Pause();
            }
            else
            {
                vp.Pause();
            }

           
        }
    }

    public void ChangeToFalse()
    {
        secondButton.SetActive(false);
        foreach (VideoPlayer vp in vidArray)
        {
            if (vp == vidArray[1])
            {
                vp.Play();
                vp.isLooping = false;
                //if song ends.... ChangeToStandBy
                float vpLength = (float)vidArray[1].clip.length;
                Invoke("ChangeToStandBy", vpLength);
            }
            else if (vp == vidArray[3])
            {
                vp.time = 0.1f;
                vp.Pause();
            }
            else
            {
                vp.Pause();
            }
        }
    }



    public void PowerOnIsOn()
    {
        firstButton.SetActive(true);
        secondButton.SetActive(false);
        btn1 = firstButton.GetComponent<Button>();
        btn2 = secondButton.GetComponent<Button>();
        foreach (VideoPlayer vp in vidArray)
        {
            vp.playOnAwake = true;
            if (vp == vidArray[0])
            {
                vp.Play();
                vp.isLooping = true;
            }
            else
            {
                vp.Pause();
            }
        }
    }
}
