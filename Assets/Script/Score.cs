

using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text scoremove;

    // Update is called once per frame
    void Update()
    {
        scoremove.text = player.position.z.ToString("0");
        
    }
}
