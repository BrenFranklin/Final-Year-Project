using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NPC01Buttons : MonoBehaviour
{
    public GameObject player;
    public GameObject NPCQuest;
    public GameObject UICurrentQuest;
    public GameObject QuestName;
    public GameObject QuestObjective;
    public GameObject MiniMap;
    public void AcceptQuest()
    {
        player.SetActive(true);
        MiniMap.SetActive(true);
        NPCQuest.SetActive(false);
        NPC01.questAccepted = true;
        StartCoroutine(SetQuestUI());
    }

    IEnumerator SetQuestUI()
    {
        QuestManager.activeQuestNumber = 2;
        yield return new WaitForSeconds(0.5f);
        UICurrentQuest.SetActive(true);
        yield return new WaitForSeconds(1f);
        QuestName.SetActive(true);
        QuestName.GetComponent<TextMeshProUGUI>().text = "Kill the mutated spider";
        yield return new WaitForSeconds(1f);
        QuestObjective.SetActive(true);
        QuestObjective.GetComponent<TextMeshProUGUI>().text = "Kill spider boss";
        yield return new WaitForSeconds(3f);
        QuestName.SetActive(false);
        QuestObjective.SetActive(false);

    }

    public void RejectQuest()
    {
        player.SetActive(true);
        MiniMap.SetActive(true);
        NPCQuest.SetActive(false);
        NPC01.questAccepted = false;
    }
}
