using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour {

	public void NextSecneBtn(string nextSecne)
    {
        SceneManager.LoadScene(nextSecne);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGameBtn()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
