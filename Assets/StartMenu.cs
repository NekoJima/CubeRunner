
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    public void GameBegin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
