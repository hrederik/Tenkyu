using UnityEngine;
using UnityEngine.SceneManagement;

public class IngamePanel : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
