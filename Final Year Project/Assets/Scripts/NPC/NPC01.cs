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
            if (distance <= 3)
            {
                Screen.lockCursor = false;
                Cursor.visible = true;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                //player.SetActive(false);
                StartCoroutine(NPC01Active());
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

        yield return new WaitForSeconds(1.5f);
        TextBox.SetActive(false);
        NPCName.SetActive(false);
        NPCText.SetActive(false);
        actionDisplay.SetActive(true);
        actionText.SetActive(true);
    }

}
