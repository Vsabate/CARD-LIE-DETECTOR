using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkButton : MonoBehaviour
{
    [SerializeField]
    private string url;

    public void ClickLink()
    {
        Application.OpenURL(url);
    }
}
