using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    //Físicas
    public Rigidbody2D rb;
    public RectTransform trans;
    bool buttonPressed;

    private Vector2 pos1;
    private Vector2 pos2;
    private Vector2 pos3;
    private Vector2 pos4;


    //HORITONZAL SLIDER
    private float slideSpeed = 150.0f;

    // Start is called before the first frame update
    void Start()
    {
        buttonPressed = false;
        pos1 = new Vector2(179.5f, 0f);
        pos2 = new Vector2(-179.5f, 0f);
        pos3 = new Vector2(trans.position.x - 2000f, 0f);
        pos4 = new Vector2(trans.position.x - 3000f, 0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (buttonPressed)
        {
            rb.velocity = Vector2.MoveTowards(pos2, pos1, slideSpeed * Time.fixedDeltaTime);
        }
    }

    public void PutTutorial()
    {
        buttonPressed = true;        
    }
}
