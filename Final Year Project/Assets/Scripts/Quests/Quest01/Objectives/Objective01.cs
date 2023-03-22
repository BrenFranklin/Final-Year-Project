using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Objective01 : MonoBehaviour
{
    public GameObject Objective;
    public static bool completed = false;
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(FinishObjective());
    }

    IEnumerator FinishObjective()
    {
        Objective.SetActive(true);
        Objective.GetComponent<TextMeshProUGUI>().text = "return to Board";
        yield return new WaitForSeconds(1f);
        Objective.SetActive(false);
        completed = true;
        Destroy(gameObject);
        
    }
}
