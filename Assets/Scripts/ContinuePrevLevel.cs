using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinuePrevLevel : MonoBehaviour {

    public GameObject loadingPanel;
    public Slider loadingBarSlider;

    public void Continue ()
    {
        AdManager.Instance.ShowVideo();
        StartCoroutine(LoadTheNextFlippingScene());
    }

    IEnumerator LoadTheNextFlippingScene()
    {

        string sceneName = PlayerPrefs.GetString("lastLoadedScene");
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);


        while (operation.isDone == false)
            loadingBarSlider.value = operation.progress * 100;
        yield return null;
    }
}
