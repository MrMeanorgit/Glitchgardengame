using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadind : MonoBehaviour
{
    [SerializeField] int WaitTime = 4;
    int presentscene;
    // Start is called before the first frame update
    void Start()
    {
        presentscene = SceneManager.GetActiveScene().buildIndex;
        if(presentscene == 0)
        {
            StartCoroutine(waitfortime());
        }

    }
    IEnumerator waitfortime()
    {
        yield return new WaitForSeconds(WaitTime);
        LoadnextScene();

    }
    public void Restartscene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(presentscene);
    }
    public void Mainscreen()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game Screen");
    }
    public void Optionsmenu()
    {
        
        SceneManager.LoadScene("option menu");
    }
    public void LoadnextScene()
    {
        SceneManager.LoadScene(presentscene + 1);
    }

    // Update is called once per frame

    public void YouLose()
    {
        SceneManager.LoadScene("Loose Screen");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
