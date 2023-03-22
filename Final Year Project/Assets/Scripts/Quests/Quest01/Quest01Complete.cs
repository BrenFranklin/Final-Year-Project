using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quest01Complete : MonoBehaviour
{
    public float distance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject UIQuest;
    public GameObject player;    
    public GameObject NoticeQuest;
    public GameObject beginnerSword;
    public GameObject beginnerBow;
    
    public bool quest01Completed = false;

    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= 3 && quest01Completed == false && Objective01.completed == true)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            actionText.GetComponent<TextMeshProUGUI>().text = "Turn in quest";
        }

        if (Input.GetButtonDown("Action") && quest01Completed == false && Objective01.completed == true)
        {
            if (distance <= 3)
            {
                GlobalExp.CurrentExp += 100;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                
                quest01Completed = true;
                beginnerSword.SetActive(true);
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }




}
