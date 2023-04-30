using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HomeButton : MonoBehaviour
{
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
            HomeButton.bankChoice = bankOption;
            SceneManager.LoadScene("MainScene");
        }
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
