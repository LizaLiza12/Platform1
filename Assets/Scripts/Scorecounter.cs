using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class countcrystal : MonoBehaviour
{
    [SerializeField] private Text textUI;
    private int sccrystal = 0;

    [SerializeField] private Text textfinal;
    private int finalsccrystal;

    [SerializeField] private GameObject finalUI;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("coin"))
        {
           
        }
        else if (collision.gameObject.CompareTag("secretbonus"))
        {
            
        }
        else if (collision.gameObject.CompareTag("finish1") || collision.gameObject.CompareTag("finish2"))
        {
            ScoreLevel();
        }
    }
    private void ScoreLevel()
    {
        finalsccrystal = sccrystal;

        if (textfinal != null) textfinal.text = finalsccrystal.ToString();
        if (finalUI != null) finalUI.SetActive(true);
    }
}
