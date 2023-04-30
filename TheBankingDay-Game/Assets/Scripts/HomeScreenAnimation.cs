using UnityEngine;
using UnityEngine.UI;

public class HomeScreenAnimation : MonoBehaviour
{
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject settingsButton;
    private RectTransform rectTransform;

    private float moveSpeed = 375f;
    private float stopHeight = -70f;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        playButton.SetActive(false);
        settingsButton.SetActive(false);
    }

    private void Update()
    {
        if (rectTransform.anchoredPosition.y < stopHeight)
        {
            rectTransform.anchoredPosition += Vector2.up * moveSpeed * Time.deltaTime;
        }
        else
        {
            playButton.SetActive(true);
            settingsButton.SetActive(true);
        }
    }
}
