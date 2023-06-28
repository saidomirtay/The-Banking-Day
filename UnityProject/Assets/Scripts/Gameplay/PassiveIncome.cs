using System.Collections;
using UnityEngine;

// Скрипт привязан к каждому Bank Branch на Main Scene
public class PassiveIncome : MonoBehaviour
{
    // Банковское отделение зарабатывает 1 монетку вам кошелек каждые 3 секунды, но только днем

    [SerializeField] MoneyController moneyController;
    void Start()
    {
        StartCoroutine(EarnPassiveMoney());
    }

    private IEnumerator EarnPassiveMoney()
    {
        yield return new WaitForSeconds(3);
        if(DayNightCycle.currentTime == "day")
            moneyController.EarnMoney(1);
        StartCoroutine(EarnPassiveMoney());
    }
}
