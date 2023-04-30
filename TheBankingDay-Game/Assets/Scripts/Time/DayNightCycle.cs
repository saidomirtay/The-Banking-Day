using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField] TMP_Text dayOrNightText;
    [SerializeField] Button twiceSpeedButton;
    private Image twiceSpeedButtonImage;
    private float dayCycleInSeconds = 31f;
    private bool timePaused;
    private bool spedUp = false;

    private void Start()
    {
        twiceSpeedButtonImage = twiceSpeedButton.GetComponent<Image>();
    }

    private void Update()
    {
        if (!timePaused)
        {
            float angleThisFrame = Time.deltaTime / dayCycleInSeconds * 360f;
            angleThisFrame = spedUp ? angleThisFrame * 2 : angleThisFrame;
            transform.RotateAround(Vector3.zero, Vector3.right, angleThisFrame);
            transform.LookAt(Vector3.zero);

            string currentTime = transform.eulerAngles.x >= 180f ? "night" : "day";
            dayOrNightText.text = "Time - " + currentTime;
        }
    }

    public void Pause(bool pause)
    {
        timePaused = pause;
    }

    public void SpeedUp()
    {
        spedUp = !spedUp;
        twiceSpeedButtonImage.color = twiceSpeedButtonImage.color == Color.white ? Color.grey : Color.white;
    }
}
