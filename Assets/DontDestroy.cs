
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    static DontDestroy dontDestroy;

    void Start()
    {
        DontDestroyOnLoad(this);

        if (dontDestroy == null)
        {
            dontDestroy = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    //public void LoadScene()
    //{
    //    if (SceneManager.GetActiveScene().name == "Game")
    //    {
    //        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    //    }
    //}
}