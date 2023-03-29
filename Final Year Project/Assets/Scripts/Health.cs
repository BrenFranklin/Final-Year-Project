using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{

    public static int hitPoints = 100;
    public int health;
    public GameObject HealthText;

    void Update()
    {
        health = hitPoints;

        HealthText.GetComponent<TextMeshProUGUI>().text = "HP " + hitPoints;

        if(hitPoints <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
