using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour {

	public void NextSecneBtn(string nextSecne)
    {
        SceneManager.LoadScene(nextSecne);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void NewSecneBtn()
    {
        SaveGame.levelCompleted = 0;
        SceneManager.LoadScene("Ingredients_Level01");
    }

    public void LoadSecneBtn()
    {
        if (SaveGame.levelCompleted == 1)
        {
            SceneManager.LoadScene("Ingredients_Level02");
        }
        else if (SaveGame.levelCompleted == 2)
        {
            SceneManager.LoadScene("Ingredients_Level03");

        }
        else if (SaveGame.levelCompleted == 3)
        {
            SceneManager.LoadScene("Ingredients_Level04");

        }
        else if (SaveGame.levelCompleted == 4)
        {
            SceneManager.LoadScene("Ingredients_Level05");
        }
        else
        {
            SceneManager.LoadScene("Ingredients_Level01");
        }
    }
    public void MenuBtn()
    {
        SceneManager.LoadScene("MenuStart");
    }


    public void ExitGameBtn()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    private void Update()
    {
        //SaveGame.ReadLevel();

        //Debug.Log(SaveGame.levelCompleted);
    }
}
