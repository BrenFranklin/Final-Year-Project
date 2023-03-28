using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{
    public int spiderHealth = 15;
    public GameObject spider;
    public int spiderStatus;
    public int baseEXP = 10;
    public int CalculatedEXP;
    public SpiderAI spiderAIScript;
    public static int GlobalSpider;

    void Start()
    {
        spiderAIScript = GetComponent<SpiderAI>();
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
        spiderAIScript.enabled = false;
        spiderStatus = 6;
        CalculatedEXP = baseEXP * GlobalLevel.CurrentLevel;
        yield return new WaitForSeconds(0.8f);
        spider.GetComponent<Animator>().Play("die");
        GlobalExp.CurrentExp += CalculatedEXP;
    }
}
