using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAfterTime : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 15f;
    [SerializeField]
    private string sceneNmaeToLoad;
    private float timeElapsed;
    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(0);
        }
    }
}
