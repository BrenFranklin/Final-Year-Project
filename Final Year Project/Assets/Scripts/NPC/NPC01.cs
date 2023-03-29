using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NPC01 : MonoBehaviour
{
    public float distance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject player;
    public GameObject TextBox;
    public GameObject NPCName;
    public GameObject NPCText;
    public static bool questAccepted = false;
    public GameObject NPCQuest;

    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= 3)
        {
            actionText.GetComponent<TextMeshProUGUI>().text = "Talk";
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (distance <= 3 && questAccepted == false)
            {
                Screen.lockCursor = false;
                Cursor.visible = true;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                //player.SetActive(false);
                StartCoroutine(NPC01Active());
            }

            if (distance <= 3 && questAccepted == true)
            {
                Screen.lockCursor = false;
                Cursor.visible = true;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                //player.SetActive(false);
                StartCoroutine(NPC01Accepted());
            }

            if (distance <= 3 && questAccepted == true && SpiderBossEnemy.SpiderBossDead == true)
            {
                Screen.lockCursor = false;
                Cursor.visible = true;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                //player.SetActive(false);
                StartCoroutine(NPC01Completed());
            }

            if (distance <= 3 && questAccepted == false && SpiderBossEnemy.SpiderBossDead == true)
            {
                Screen.lockCursor = false;
                Cursor.visible = true;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                //player.SetActive(false);
                StartCoroutine(NPC01CompletedVer2());
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

    IEnumerator NPC01Active()
    {
        TextBox.SetActive(true);
        NPCName.GetComponent<TextMeshProUGUI>().text = "Warrior David";
        NPCName.SetActive(true);
        NPCText.GetComponent<TextMeshProUGUI>().text = "Greetings Traveler, I need some assistance";
        NPCText.SetActive(true);
        yield return new WaitForSeconds(1f);
        NPCText.GetComponent<TextMeshProUGUI>().text = "There is a mutated spider in the woods that is causing havoc";
        
        yield return new WaitForSeconds(1f);
        NPCText.GetComponent<TextMeshProUGUI>().text = "Can I ask you to get rid of it for us";
        NPCQuest.SetActive(true);
        
        while (NPCQuest.activeInHierarchy)
        {
            yield return null;
        }
        if(questAccepted == true)
        {
            yield return new WaitForSeconds(1f);
            NPCText.GetComponent<TextMeshProUGUI>().text = "Thank you kind traveler. I pray for your success";
            yield return new WaitForSeconds(1f);
            TextBox.SetActive(false);
            NPCName.SetActive(false);
            NPCText.SetActive(false);
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }
        else
        {
            yield return new WaitForSeconds(1f);
            NPCText.GetComponent<TextMeshProUGUI>().text = "I see. That is too bad but I understand";
            yield return new WaitForSeconds(1f);
            TextBox.SetActive(false);
            NPCName.SetActive(false);
            NPCText.SetActive(false);
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }

     
    }

    IEnumerator NPC01Accepted()
    {
        TextBox.SetActive(true);
        NPCName.GetComponent<TextMeshProUGUI>().text = "Warrior David";
        NPCName.SetActive(true);
        NPCText.GetComponent<TextMeshProUGUI>().text = "Greetings Traveler, how goes the hunt";
        NPCText.SetActive(true);
        yield return new WaitForSeconds(1f);
        TextBox.SetActive(false);
        NPCName.SetActive(false);
        NPCText.SetActive(false);
        actionDisplay.SetActive(true);
        actionText.SetActive(true);
    }

    IEnumerator NPC01Completed()
    {
        TextBox.SetActive(true);
        NPCName.GetComponent<TextMeshProUGUI>().text = "Warrior David";
        NPCName.SetActive(true);
        NPCText.GetComponent<TextMeshProUGUI>().text = "Thank you for killing the spider kind traveler. Here, your reward.";
        NPCText.SetActive(true);
        yield return new WaitForSeconds(1f);
        TextBox.SetActive(false);
        NPCName.SetActive(false);
        NPCText.SetActive(false);
        actionDisplay.SetActive(true);
        actionText.SetActive(true);
    }

    IEnumerator NPC01CompletedVer2()
    {
        TextBox.SetActive(true);
        NPCName.GetComponent<TextMeshProUGUI>().text = "Warrior David";
        NPCName.SetActive(true);
        NPCText.GetComponent<TextMeshProUGUI>().text = "It seems some mysterious traveler has killed the mutated spider for us.";
        NPCText.SetActive(true);
        yield return new WaitForSeconds(1f);
        TextBox.SetActive(false);
        NPCName.SetActive(false);
        NPCText.SetActive(false);
        actionDisplay.SetActive(true);
        actionText.SetActive(true);
    }
}
