using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsManager : MonoBehaviour
{
    [Header("Config Player 1")]
    [SerializeField] private Slider sliderPlayer01;
    [SerializeField] private TextMeshProUGUI textPlayer01;
    [SerializeField] private Movement scriptPlayer1;

    [Header("Config Player 2")]
    [SerializeField] private Slider sliderPlayer02;
    [SerializeField] private TextMeshProUGUI textPlayer02;
    [SerializeField] private Movement scriptPlayer2;
    

    void Start()
    {
        UpdateSpeedPlayer1(sliderPlayer01.value);
        UpdateSpeedPlayer2(sliderPlayer02.value);
    }

    public void UpdateSpeedPlayer1(float newSpeed)
    {
        textPlayer01.text = newSpeed.ToString();
        scriptPlayer1.moveSpeed = newSpeed;
    }

    public void UpdateSpeedPlayer2(float newSpeed)
    {
        textPlayer02.text = newSpeed.ToString();
        scriptPlayer2.moveSpeed = newSpeed;
    }
}
