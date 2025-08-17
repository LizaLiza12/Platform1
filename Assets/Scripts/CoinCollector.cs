using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public Text moneyText;
    public Button resetButton; // ������ �� ������ ������
    private int money;

    private void Start()
    {
        // �������� �����
        money = PlayerPrefs.GetInt("Money", 0);
        UpdateMoneyText();

        // �������� ����������� � ������
        if (resetButton != null)
        {
            resetButton.onClick.AddListener(ResetMoney);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coin"))
        {
            Destroy(collision.gameObject);
            money += 1;
        }
        else if (collision.CompareTag("secretbonus"))
        {
            Destroy(collision.gameObject);
            money += 10;
        }  

        if (collision.CompareTag("coin") || collision.CompareTag("secretbonus"))
        {
            PlayerPrefs.SetInt("Money", money);
            UpdateMoneyText();
        }
    }

    private void UpdateMoneyText()
    {
        moneyText.text = money.ToString();
    }

    private void ResetMoney()
    {
        money = 0;
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        UpdateMoneyText();
    }
}
