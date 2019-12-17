using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	public void LoadNextLevel ()
	{
        AdManager.Instance.ShowVideo();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}
