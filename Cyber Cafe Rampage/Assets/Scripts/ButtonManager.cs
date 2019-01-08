using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour {

	public void NextSecneBtn(string nextSecne)
    {
        SceneManager.LoadScene(nextSecne);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void MenuBtn()
    {
        SceneManager.LoadScene("MenuStart");
    }
    public void LoadGameBtn()
    {
        
    }
    public void ExitGameBtn()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void SaveGameBtn(int levelCommp)
    {
        //Save.level = levelCommp;
    }
}
