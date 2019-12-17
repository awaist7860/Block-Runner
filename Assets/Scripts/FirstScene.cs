using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour {

    public GameObject wigLogo;
    public GameObject presents;
    public GameObject BrLogo;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(FirstScenemurator());
	}

    IEnumerator FirstScenemurator ()
    {
        wigLogo.SetActive(true);
        presents.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        wigLogo.SetActive(false);
        presents.SetActive(false);
        BrLogo.SetActive(true);
        SceneManager.LoadSceneAsync("Menu");
    }

}
