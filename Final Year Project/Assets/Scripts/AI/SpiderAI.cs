using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAI : MonoBehaviour
{
    public GameObject Player;
    public float TargetDistance;
    public float AllowedRange = 40;
    public GameObject Spider;
    public float SpiderSpeed;
    public int attackTrigger;
    public RaycastHit Shot;
    public int SpiderDamage;

    void Update()
    {
        transform.LookAt(Player.transform);
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if (TargetDistance <= AllowedRange)
            {
                SpiderSpeed = 0.02f;
                if (attackTrigger == 0)
                {
                    Spider.GetComponent<Animator>().Play("walk");
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(Player.transform.position.x, Player.transform.position.y + 0.3f, Player.transform.position.z), SpiderSpeed);
                }
            }
            else
            {
                SpiderSpeed = 0;
                Spider.GetComponent<Animator>().Play("idle");
            }

            if (attackTrigger == 1)
            {
                if (SpiderDamage == 0)
                {
                    SpiderSpeed = 0;
                    Spider.GetComponent<Animator>().Play("attack");
                    StartCoroutine(TakingDamage());
                }

            }

        }
    }

    void OnTriggerEnter()
    {
        attackTrigger = 1;
    }

    void OnTriggerExit()
    {
        attackTrigger = 0;
    }

    IEnumerator TakingDamage()
    {
        SpiderDamage = 2;
        yield return new WaitForSeconds(0.5f);
        if (SpiderEnemy.GlobalSpider != 6)
        {
            if (attackTrigger == 1)
            {
                Health.hitPoints -= 1;
            }

        }

        yield return new WaitForSeconds(0.5f);
        SpiderDamage = 0;

    }

}
