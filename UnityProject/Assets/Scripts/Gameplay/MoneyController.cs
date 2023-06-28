using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Скрипт привязан к Money Controller на Main Scene
public class MoneyController : MonoBehaviour
{
    // Другие скрипты отсылаются на этот, когда нужно добавмть деньги в Вашу казну

    [SerializeField] TMP_Text wallet;
    public static float moneyTotal = 0;

    private void Start()
    {
        ChangeText();
    }

    public void EarnMoney(int amount)
    {
        moneyTotal += amount;
        ChangeText();
    }

    public void ChangeText()
    {
        wallet.text = moneyTotal.ToString();
    }
}
