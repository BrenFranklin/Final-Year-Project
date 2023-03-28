using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
    public GameObject sword;
    public int swordStatus;
    void Update()
    {
        if(swordStatus == 0)
        {
            sword.GetComponent<Animator>().Play("New State");
        }

        if (Input.GetButtonDown("Attack1") && swordStatus == 0)
        {
            StartCoroutine(swingSwordAction());
        }
    }

    IEnumerator swingSwordAction()
    {
        swordStatus = 1;
        
        sword.GetComponent<Animator>().Play("SwordAnim");
        
        swordStatus = 2;
        
        yield return new WaitForSeconds(1.0f);

        swordStatus = 0;
    }
}
