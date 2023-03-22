using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{
    public int spiderHealth = 15;
    public GameObject spider;
    public int spiderStatus;

    void DamageSpider(int spiderTakeDamage)
    {
        spiderHealth -= spiderTakeDamage;
    }

    // Update is called once per frame
    void Update()
    {
        if (spiderHealth <= 0)
        {
            if(spiderStatus == 0)
            {

            }
            StartCoroutine(DeathSpider());
        }
    }

    IEnumerator DeathSpider()
    {
        spiderStatus = 6;
        yield return new WaitForSeconds(0.8f);
        spider.GetComponent<Animation>().Play("die");
        GlobalExp.CurrentExp += 50;
    }
}
