using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class CardLieDetector : MonoBehaviour
{
    #region variables
    //variables
    public OnButtonDown buttonHoldScript;
    public SceneManag sceneManage;
    public VideoPlayer[] vidArray;
    public GameObject firstButton;
    public GameObject secondButton;
    Button btn1;
    Button btn2;
    Button.ButtonClickedEvent onClick;

    public int counter;
    private int originalCounter = 0;
    private int maxCounter = 4;

    public SelectingCard selectCardScript;
    public GameObject finalCard;
    public string cardTag;

    // PLAY CARD SOUND
    public PlaySound cardSoundScript;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        finalCard = GameObject.FindGameObjectWithTag(cardTag);

        PowerOnIsOn();        
        counter = originalCounter;
        
        if (finalCard.GetComponent<Image>().sprite == null)
        {
            //Assign Sprite
            selectCardScript.symbolSelected = "SPADE";
            selectCardScript.numberSelected = 1;
            selectCardScript.cardSelected = selectCardScript.card_table[39];
            finalCard.GetComponent<Image>().sprite = selectCardScript.cardSelected;
        }

        finalCard.GetComponent<Image>().color = new Color(1,1,1,0);
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
                        //btn2.onClick.AddListener(ChangeToFalse); ESTO SE PUEDE BORRAR
                        if (buttonHoldScript.isDown)
                        {
                            ChangeToFalse();
                            buttonHoldScript.isDown = false;
                        }
                    }
                    else
                    {
                        //btn2.onClick.AddListener(ChangeToTrue); ESTO SE PUEDE BORRAR
                        if (buttonHoldScript.isDown)
                        {
                            ChangeToTrue();
                            buttonHoldScript.isDown = false;                          
                        }
                    }
                }
            }
        }
        if (counter >= maxCounter)
        {
            secondButton.SetActive(false);
            StartCoroutine(CardCoroutine());
            counter = originalCounter;
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

                Invoke("CounterUp", vpLength);
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

                Invoke("CounterUp", vpLength);
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

    public void CounterUp()
    {
        counter = counter + 1;
    }

    #region CardCoroutines
    public IEnumerator CardCoroutine()
    {

        cardSoundScript.PlayCardSound();
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(ShowCard());
        /*yield return new WaitForSeconds(10.0f);
         StartCoroutine(BlinkingCard());
         yield return null;
         StartCoroutine(DisapearCard());*/
        yield return null;
    }

    public IEnumerator ShowCard()
    {
        for (float i = 0.0f; i <= 0.8f; i += 0.1f)
        {
            finalCard.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, i);
            yield return new WaitForSeconds(0.05f);
        }
        yield return null;
    }

    public IEnumerator BlinkingCard()
    {
        for (float i = 0.8f; i >= 0.6f; i -= 0.1f)
        {
            finalCard.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, i);
            yield return new WaitForSeconds(0.05f);
        }

        int blinkingCounter = 0;
        while (!(blinkingCounter>=15))
        {
            for (float i = 0.6f; i <= 0.8f; i += 0.1f)
            {
                finalCard.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, i);
                yield return new WaitForSeconds(0.05f);
            }
            yield return new WaitForSeconds(1.0f);
            for (float i = 0.8f; i >= 0.6f; i -= 0.1f)
            {
                finalCard.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, i);
                yield return new WaitForSeconds(0.05f);
            }
            blinkingCounter = blinkingCounter + 1;
        }
        yield return null;
    }

    public IEnumerator DisapearCard()
    {
        for (float i = 0.8f; i >= 0.0f; i -= 0.1f)
        {
            finalCard.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, i);
            yield return new WaitForSeconds(0.05f);
        }
        finalCard.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, 0.0f);
        yield return null;
    }
    #endregion
}

