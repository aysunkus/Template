using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{

    public static bool sound = false;

    void Awake()
    {
        if (!sound)
        {
            DontDestroyOnLoad(this.gameObject);
            sound = true;

        }
    }

    public void LoadScene()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            SceneManager.LoadScene("Game", LoadSceneMode.Single);
        }
    }
}