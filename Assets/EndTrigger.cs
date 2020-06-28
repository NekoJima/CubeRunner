
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagement gameManager;
    void OnTriggerEnter()
    {
        gameManager.GameComplete();
    }
}
