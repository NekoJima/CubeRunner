
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    bool EndGame = false;
    public float DelayTime ;
    public GameObject CompleteLevel;
    public void GameComplete()
    {
        CompleteLevel.SetActive(true);
    }
    public void GameOver()
    {
        if (EndGame == false)
        {
            EndGame = true;
            Invoke("Restart", DelayTime);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

