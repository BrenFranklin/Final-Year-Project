using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Quest01 : MonoBehaviour
{
    public float distance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject UIQuest;
    public GameObject player;
    public GameObject NoticeCam;
    public GameObject NoticeQuest;
    public static bool quest01Accepted = false;


    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= 3 && quest01Accepted == false)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action") && quest01Accepted == false)
        {
            if (distance <= 3)
            {
                Screen.lockCursor = false;
                Cursor.visible = true;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                NoticeQuest.SetActive(false);
                UIQuest.SetActive(true);
                NoticeCam.SetActive(true);
                player.SetActive(false);
                quest01Accepted = true;
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }




}
