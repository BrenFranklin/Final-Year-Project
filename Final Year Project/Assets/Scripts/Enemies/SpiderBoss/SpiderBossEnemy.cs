using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBossEnemy : MonoBehaviour
{
    public int spiderHealth = 50;
    public GameObject spider;
    public int spiderStatus;
    public int baseEXP = 100;
    public SpiderBossAI spiderBossAIScript;
    public static int GlobalSpider;
    public GameObject oldNPC;
    public GameObject newNPC;
    public SpiderBossAttack spiderAttackScript;
    public static bool SpiderBossDead;

    void Start()
    {
        spiderBossAIScript = GetComponent<SpiderBossAI>();
        spiderAttackScript = GetComponent<SpiderBossAttack>();
    }


    void DamageSpider(int spiderTakeDamage)
    {
        spiderHealth -= spiderTakeDamage;
    }

    
    void Update()
    {
        GlobalSpider = spiderStatus;

        if (spiderHealth <= 0)
        {
            if(spiderStatus == 0)
            {
                StartCoroutine(DeathSpider());
            }
            
        }
    }

    IEnumerator DeathSpider()
    {
        spiderBossAIScript.enabled = false;
        spiderAttackScript.enabled = false;
        spiderStatus = 6;
        yield return new WaitForSeconds(0.8f);
        spider.GetComponent<Animator>().Play("Death");
        GlobalExp.CurrentExp += baseEXP;
        SpiderBossDead = true;
        oldNPC.SetActive(false);
        newNPC.SetActive(true);
    }
}
