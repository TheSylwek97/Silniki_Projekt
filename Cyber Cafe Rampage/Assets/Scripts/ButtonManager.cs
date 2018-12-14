using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour {

	public void NewGameBtn(string NewGameLevel1)
    {
        SceneManager.LoadScene(NewGameLevel1);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }
}
