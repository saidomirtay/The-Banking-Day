using UnityEngine;
using UnityEngine.SceneManagement;

// Скрипт привязан к некоторым кнопкам
public class HomeButton : MonoBehaviour
{
    // Закрепление выбора банка и последующая смена сцены

    [SerializeField] string bankOption;
    public static string bankChoice;
    public void StartGame()
    {
        if (bankOption == "" && bankChoice == null)
        {
            SceneManager.LoadScene("BankChoose");
        }
        else
        {
            bankChoice = bankOption;
            SceneManager.LoadScene("MainScene");
        }
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
