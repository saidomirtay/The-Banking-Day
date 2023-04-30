using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreenAnimation : MonoBehaviour
{
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject settingsButton;
    private RectTransform rectTransform;

    private float moveSpeed = 400f;
    private float stopHeight = -90f;

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
            if (Input.GetMouseButton(0))
            {
                rectTransform.anchoredPosition += Vector2.up * moveSpeed * Time.deltaTime * 10;
            }
        }
        else
        {
            playButton.SetActive(true);
            settingsButton.SetActive(true);
        }
    }
}
