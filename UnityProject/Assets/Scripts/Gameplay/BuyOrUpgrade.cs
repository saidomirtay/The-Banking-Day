using UnityEngine;
using TMPro;

// Скрипт привязан к Central Bank на Main Scene
public class BuyOrUpgrade : MonoBehaviour
{
    [SerializeField] MoneyController moneyController;
    [SerializeField] TMP_Text buyButtonText;
    [SerializeField] TMP_Text upgradeButtonText;

    [SerializeField] GameObject[] bankBranches;

    private float heightIncrease = 100f;
    private float upgradeMultiplier = 2f;
    private int upgradeDegree = 0;
    private int startUpgradePrice = 50;

    private float buyMultiplier = 1.5f;
    private int buyDegree = 0;
    private int startBuyPrice = 100;

    private void Start()
    {
        upgradeButtonText.text = "RAISE: " + startUpgradePrice;
        buyButtonText.text = "BUY: " + startBuyPrice;
    }

    // При нажатии кнопки RAISE, количество этажей в центральном банке и профит с одного клика возрастают
    public void Upgrade()
    {
        int price = Mathf.RoundToInt(startUpgradePrice * Mathf.Pow(upgradeMultiplier, upgradeDegree));
        if (MoneyController.moneyTotal >= price)
        {
            MoneyController.moneyTotal -= price;
            moneyController.ChangeText();

            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + heightIncrease, transform.localScale.z);
            OnClick.clickProfit++;

            upgradeDegree++;
            upgradeButtonText.text = "RAISE: " + Mathf.RoundToInt(startUpgradePrice * Mathf.Pow(upgradeMultiplier, upgradeDegree));
        }
    }

    // При нажатии кнопки BUY, вы покупаете отделение банка, которое приносит вам пассивный доход
    public void Buy()
    {
        if (buyDegree < 8)
        {
            int price = Mathf.RoundToInt(startBuyPrice * Mathf.Pow(buyMultiplier, buyDegree));
            if (MoneyController.moneyTotal >= price)
            {
                MoneyController.moneyTotal -= price;
                moneyController.ChangeText();

                bankBranches[buyDegree].SetActive(true);

                buyDegree++;
                if(buyDegree == 8)
                {
                    buyButtonText.text = "BUY: -";
                }
                else
                {
                    buyButtonText.text = "BUY: " + Mathf.RoundToInt(startBuyPrice * Mathf.Pow(buyMultiplier, buyDegree));
                }
            }
        }
    }
}
