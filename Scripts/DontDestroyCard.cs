using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyCard : MonoBehaviour
{
    public string cardTag;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(cardTag);

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
