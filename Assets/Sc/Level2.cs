using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    public void LoadSceneBaru(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
}