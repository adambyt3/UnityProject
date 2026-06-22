using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Panels")]
    public GameObject settingsPanel;
    public GameObject levelSelectPanel;
    public GameObject creditsPanel;
    public GameObject exitPanel;

    private void Start()
    {
        settingsPanel.SetActive(false);
        levelSelectPanel.SetActive(false);
        creditsPanel.SetActive(false);
        exitPanel.SetActive(false);
    }

    // =========================
    // SETTINGS
    // =========================
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }

    // =========================
    // LEVEL SELECT
    // =========================
    public void OpenLevelSelect()
    {
        levelSelectPanel.SetActive(true);
    }

    public void CloseLevelSelect()
    {
        levelSelectPanel.SetActive(false);
    }

    // =========================
    // CREDITS
    // =========================
    public void OpenCredits()
    {
        creditsPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        creditsPanel.SetActive(false);
    }

    // =========================
    // EXIT PANEL
    // =========================
    public void OpenExitPanel()
    {
        exitPanel.SetActive(true);
    }

    public void CloseExitPanel()
    {
        exitPanel.SetActive(false);
    }

    // =========================
    // LOAD SCENES
    // =========================
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    // =========================
    // EXIT GAME
    // =========================
    public void ExitGame()
    {
        Debug.Log("Exit Game");

        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}