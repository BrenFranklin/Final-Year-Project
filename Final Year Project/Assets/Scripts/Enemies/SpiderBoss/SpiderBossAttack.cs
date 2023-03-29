using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBossAttack : MonoBehaviour
{
    public GameObject spiderBoss;
    public int attackTrigger;
    public int dealingDamage;

    void Update()
    {
        if (attackTrigger == 0)
        {
            spiderBoss.GetComponent<Animator>().Play("Walk");
        }
        if (attackTrigger == 1)
        {
            if (dealingDamage == 0)
            {
                spiderBoss.GetComponent<Animator>().Play("Attack");
                StartCoroutine(TakingDamage());
            }
        }
    }

    IEnumerator TakingDamage()
    {
        dealingDamage = 2;
        yield return new WaitForSeconds(0.5f);
        if (SpiderEnemy.GlobalSpider != 6)
        {
            if (attackTrigger == 1)
            {
                Health.hitPoints -= 1;
            }

        }

        yield return new WaitForSeconds(0.5f);
        dealingDamage = 0;

    }

    void OnTriggerEnter()
    {
        attackTrigger = 1;
    }

    void OnTriggerExit()
    {
        attackTrigger = 0;
    }
}
