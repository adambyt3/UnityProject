using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void OpenPlay()
    {
        // jika PLAY panel pakai animasi popup, aktifkan di sini
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}