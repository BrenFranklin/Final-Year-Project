using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSpider : MonoBehaviour
{
    public int spiderTakeDamage = 5;
    public float targetDistance;
    public float allowedRange = 1.3f;

    void Update()
    {
        if (Input.GetButtonDown("Attack1"))
        {
            RaycastHit Hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
            {
                targetDistance = Hit.distance;
                if(targetDistance <= allowedRange)
                {
                    Hit.transform.SendMessage("DamageSpider", spiderTakeDamage, SendMessageOptions.DontRequireReceiver);
                }
            }

        }
    }


}
