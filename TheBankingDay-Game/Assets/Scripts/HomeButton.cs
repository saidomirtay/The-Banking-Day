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
        if (bankOption == "")
        {
            SceneManager.LoadScene("BankChoose");
        }
        else
        {
            SceneManager.LoadScene("MainScene");
            HomeButton.bankChoice = bankOption;
        }
    }
}
