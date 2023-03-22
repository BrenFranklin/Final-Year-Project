using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectButtonQuest01 : MonoBehaviour
{
    public GameObject noticeCam;
    public Button acceptButton;
    public bool activated;

    // Update is called once per frame
    void Update()
    {
        if(noticeCam.activeInHierarchy && activated == false)
        {
            acceptButton.Select();
            activated = true;
        }
    }
}
