using UnityEngine;

public class IUmanager : MonoBehaviour
{

    [Header("Config UI panels")]
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject optionsPanel;
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private GameObject pauseMenuPanel;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void PlayButton()
    {
        mainMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ShowOptions()
    {
        optionsPanel.SetActive(true);
    }

    public void HideOptions()
    {
        optionsPanel.SetActive(false);
    }

    public void ShowCredits()
    {
        creditsPanel.SetActive(true);
    }

    public void ReturnToMainMenu()
    {
        pauseMenuPanel.SetActive(false); 
        mainMenuPanel.SetActive(true); 
        Time.timeScale = 0f;             
    }

    public void HideCredits()
    {
        creditsPanel.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();


#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void TogglePause()
    {
        pauseMenuPanel.SetActive(!pauseMenuPanel.activeSelf);

        if (pauseMenuPanel.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
