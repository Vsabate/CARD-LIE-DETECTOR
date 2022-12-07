using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectingCard : MonoBehaviour
{
    #region VARIABLES
    private string[] symbol_table = {"SPADE", "HEART", "CLUB", "DIAMOND"};
    private int[] number_table = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
    public Sprite[] card_table;

    public string symbolSelected;
    public int numberSelected;
    public Sprite cardSelected;

    public SpriteRenderer temporalCard;

    public Button[] btnArray;
    Button.ButtonClickedEvent onClick;


    public GameObject finalCard;
    public string cardTag;

    #endregion





    // Start is called before the first frame update
    void Start()
    {
        finalCard = GameObject.FindGameObjectWithTag(cardTag);

        if (finalCard.GetComponent<Image>().sprite == null)
        {
            symbolSelected = "SPADE";
            numberSelected = 1;
            cardSelected = card_table[39];
            finalCard.GetComponent<Image>().sprite = cardSelected;
        }

    }

    // Update is called once per frame
    void Update()
    {
        CheckChars();
        CheckCard();
        Debug.Log(symbolSelected + " " + numberSelected);
    }



    void CheckChars()
    {
        btnArray[0].onClick.AddListener(AssignChar_A);
        btnArray[1].onClick.AddListener(AssignChar_2);
        btnArray[2].onClick.AddListener(AssignChar_3);
        btnArray[3].onClick.AddListener(AssignChar_4);
        btnArray[4].onClick.AddListener(AssignChar_5);
        btnArray[5].onClick.AddListener(AssignChar_6);
        btnArray[6].onClick.AddListener(AssignChar_7);
        btnArray[7].onClick.AddListener(AssignChar_8);
        btnArray[8].onClick.AddListener(AssignChar_9);
        btnArray[9].onClick.AddListener(AssignChar_10);
        btnArray[10].onClick.AddListener(AssignChar_J);
        btnArray[11].onClick.AddListener(AssignChar_Q);
        btnArray[12].onClick.AddListener(AssignChar_K);
        btnArray[13].onClick.AddListener(AssignSymb_CLUB);
        btnArray[14].onClick.AddListener(AssignSymb_DIAMOND);
        btnArray[15].onClick.AddListener(AssignSymb_HEART);
        btnArray[16].onClick.AddListener(AssignSymb_SPADE);
    }
    void CheckCard()
    {
        // SPADE
        if (symbolSelected == symbol_table[0] && numberSelected == number_table[0])
        {
            cardSelected = card_table[39];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[1])
        {
            cardSelected = card_table[40];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[2])
        {
            cardSelected = card_table[41];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[3])
        {
            cardSelected = card_table[42];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[4])
        {
            cardSelected = card_table[43];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[5])
        {
            cardSelected = card_table[44];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[6])
        {
            cardSelected = card_table[45];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[7])
        {
            cardSelected = card_table[46];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[8])
        {
            cardSelected = card_table[47];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[9])
        {
            cardSelected = card_table[48];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[10])
        {
            cardSelected = card_table[49];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[11])
        {
            cardSelected = card_table[50];
        }
        else if (symbolSelected == symbol_table[0] && numberSelected == number_table[12])
        {
            cardSelected = card_table[51];
        }
        // HEART
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[0])
        {
            cardSelected = card_table[26];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[1])
        {
            cardSelected = card_table[27];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[2])
        {
            cardSelected = card_table[28];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[3])
        {
            cardSelected = card_table[29];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[4])
        {
            cardSelected = card_table[30];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[5])
        {
            cardSelected = card_table[31];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[6])
        {
            cardSelected = card_table[32];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[7])
        {
            cardSelected = card_table[33];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[8])
        {
            cardSelected = card_table[34];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[9])
        {
            cardSelected = card_table[35];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[10])
        {
            cardSelected = card_table[36];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[11])
        {
            cardSelected = card_table[37];
        }
        else if (symbolSelected == symbol_table[1] && numberSelected == number_table[12])
        {
            cardSelected = card_table[38];
        }
        // CLUB
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[0])
        {
            cardSelected = card_table[0];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[1])
        {
            cardSelected = card_table[1];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[2])
        {
            cardSelected = card_table[2];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[3])
        {
            cardSelected = card_table[3];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[4])
        {
            cardSelected = card_table[4];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[5])
        {
            cardSelected = card_table[5];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[6])
        {
            cardSelected = card_table[6];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[7])
        {
            cardSelected = card_table[7];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[8])
        {
            cardSelected = card_table[8];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[9])
        {
            cardSelected = card_table[9];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[10])
        {
            cardSelected = card_table[10];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[11])
        {
            cardSelected = card_table[11];
        }
        else if (symbolSelected == symbol_table[2] && numberSelected == number_table[12])
        {
            cardSelected = card_table[12];
        }
        // DIAMOND
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[0])
        {
            cardSelected = card_table[13];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[1])
        {
            cardSelected = card_table[14];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[2])
        {
            cardSelected = card_table[15];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[3])
        {
            cardSelected = card_table[16];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[4])
        {
            cardSelected = card_table[17];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[5])
        {
            cardSelected = card_table[18];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[6])
        {
            cardSelected = card_table[19];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[7])
        {
            cardSelected = card_table[20];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[8])
        {
            cardSelected = card_table[21];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[9])
        {
            cardSelected = card_table[22];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[10])
        {
            cardSelected = card_table[23];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[11])
        {
            cardSelected = card_table[24];
        }
        else if (symbolSelected == symbol_table[3] && numberSelected == number_table[12])
        {
            cardSelected = card_table[25];
        }


        finalCard.GetComponent<Image>().sprite = cardSelected;
    }

    #region assignFunctions
    void AssignChar_A()
    {
        numberSelected = number_table[0];
    }
    void AssignChar_2()
    {
        numberSelected = number_table[1];
    }
    void AssignChar_3()
    {
        numberSelected = number_table[2];
    }
    void AssignChar_4()
    {
        numberSelected = number_table[3];
    }
    void AssignChar_5()
    {
        numberSelected = number_table[4];
    }
    void AssignChar_6()
    {
        numberSelected = number_table[5];
    }
    void AssignChar_7()
    {
        numberSelected = number_table[6];
    }
    void AssignChar_8()
    {
        numberSelected = number_table[7];
    }
    void AssignChar_9()
    {
        numberSelected = number_table[8];
    }
    void AssignChar_10()
    {
        numberSelected = number_table[9];
    }
    void AssignChar_J()
    {
        numberSelected = number_table[10];
    }
    void AssignChar_Q()
    {
        numberSelected = number_table[11];
    }
    void AssignChar_K()
    {
        numberSelected = number_table[12];
    }

    void AssignSymb_SPADE()
    {
        symbolSelected = symbol_table[0];
    }
    void AssignSymb_HEART()
    {
        symbolSelected = symbol_table[1];
    }
    void AssignSymb_CLUB()
    {
        symbolSelected = symbol_table[2];
    }
    void AssignSymb_DIAMOND()
    {
        symbolSelected = symbol_table[3];
    }
    #endregion

}
