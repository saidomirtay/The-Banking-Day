using UnityEngine;
using TMPro;
using UnityEngine.UI;

// Скрипт привязан к Direcrional Light на Main Scene
public class DayNightCycle : MonoBehaviour
{
    [SerializeField] TMP_Text dayOrNightText;
    [SerializeField] Button twiceSpeedButton;
    private Image twiceSpeedButtonImage;
    private float dayCycleInSeconds = 31f;
    private bool timePaused;
    private bool spedUp = false;
    public static string currentTime;

    private void Start()
    {
        twiceSpeedButtonImage = twiceSpeedButton.GetComponent<Image>();
    }

    // Движение источника света вокруг нашего острова для отображения и индикации времени суток
    private void Update()
    {
        if (!timePaused)
        {
            float angleThisFrame = Time.deltaTime / dayCycleInSeconds * 360f;
            angleThisFrame = spedUp ? angleThisFrame * 2 : angleThisFrame;
            transform.RotateAround(Vector3.zero, Vector3.right, angleThisFrame);
            transform.LookAt(Vector3.zero);

            currentTime = transform.eulerAngles.x >= 180f ? "night" : "day";
            dayOrNightText.text = "Time - " + currentTime;
        }
    }

    // Остановка времени
    public void Pause(bool pause)
    {
        timePaused = pause;
    }

    // Ускорение времени вдвое
    public void SpeedUp()
    {
        spedUp = !spedUp;
        twiceSpeedButtonImage.color = twiceSpeedButtonImage.color == Color.white ? Color.grey : Color.white;
    }
}
