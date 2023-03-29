using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectButtonNPC01 : MonoBehaviour
{
    public GameObject NPCQuest;
    public Button acceptButton;
    public bool activated;
    void Update()
    {
        if (NPCQuest.activeInHierarchy && activated == false)
        {
            acceptButton.Select();
            activated = true;
        }
    }
}