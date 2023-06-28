using System.Collections;
using UnityEngine;

// Скрипт привязан к Central Bank на Main Scene
public class OnClick : MonoBehaviour
{
    [SerializeField] MoneyController moneyController;
    [SerializeField] GameObject terraceOnClick;
    public static int clickProfit = 1;

    // Заработок монеток при нажатии на себя и увеличение размера террасы для анимации
    public void OnMouseDown()
    {
        moneyController.EarnMoney(clickProfit);
        terraceOnClick.SetActive(true);
        StartCoroutine(TurnTerraceOff());
    }

    // Возвращение банка в исходное состояние
    private IEnumerator TurnTerraceOff()
    {
        yield return new WaitForSeconds(0.1f);
        terraceOnClick.SetActive(false);
    }
}
