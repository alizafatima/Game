using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class timer_script : MonoBehaviour
{
    // [SerializeField]
    public float delayBeforeLoading = 5f;
    //[SerializeField]
    public string sceneNameToLoad;

    public float timeElapsed;

    private void Start()
    {

        Invoke("loadScene", delayBeforeLoading);

        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }

    public void loadScene()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}
