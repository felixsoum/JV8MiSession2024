using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        Invoke(nameof(Restart), 2f);
    }

    private void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
