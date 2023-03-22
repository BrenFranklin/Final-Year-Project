using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static int activeQuestNumber;
    public int internalQuestNumber;

    void Update()
    {
        internalQuestNumber = activeQuestNumber; 
    }
}
