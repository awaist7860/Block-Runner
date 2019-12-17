using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
public class LoadLevel : MonoBehaviour
{

    public void LoadNextLevel(string LevelName)
    {
        AdManager.Instance.ShowVideo();
        SceneManager.LoadScene(LevelName);
    }

}
