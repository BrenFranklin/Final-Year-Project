using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Quest01Buttons : MonoBehaviour
{
    public GameObject player;
    public GameObject noticeCam;
    public GameObject UIQuest;
    public GameObject UICurrentQuest;
    public GameObject QuestName;
    public GameObject QuestObjective;
    public GameObject QuestObject;
    public void AcceptQuest()
    {
        player.SetActive(true);
        noticeCam.SetActive(false);
        UIQuest.SetActive(false);
        StartCoroutine(SetQuestUI());
    }

    IEnumerator SetQuestUI()
    {       
        QuestManager.activeQuestNumber = 1;
        QuestObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        UICurrentQuest.SetActive(true);
        yield return new WaitForSeconds(1f);
        QuestName.SetActive(true);
        QuestName.GetComponent<TextMeshProUGUI>().text = "Retrieve ball for Billy";
        yield return new WaitForSeconds(1f);
        QuestObjective.SetActive(true);
        QuestObjective.GetComponent<TextMeshProUGUI>().text = "Retrieve ball";
        yield return new WaitForSeconds(3f);
        QuestName.SetActive(false);
        QuestObjective.SetActive(false);
        
    }

    public void RejectQuest()
    {
        player.SetActive(true);
        noticeCam.SetActive(false);
        UIQuest.SetActive(false);
        Quest01.quest01Accepted = false;
    }
}
