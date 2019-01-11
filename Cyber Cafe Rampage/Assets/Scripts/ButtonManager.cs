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
        /*if(PlayerData.whichLvl > 0)
        {
            PlayerData.whichLvl = 0;
        }*/
        SceneManager.LoadScene("MenuStart");
    }
    public void LoadGameBtn()
    {
        if(PlayerData.whichLvl == 2)
        {
            SceneManager.LoadScene("Ingredients_Level02");
        }
        else if (PlayerData.whichLvl == 3)
        {
            SceneManager.LoadScene("Ingredients_Level03");
        }
        else if (PlayerData.whichLvl == 4)
        {
            SceneManager.LoadScene("Ingredients_Level04");
        }
        else if (PlayerData.whichLvl == 5)
        {
            SceneManager.LoadScene("Ingredients_Level05");
        }
        else
        {
            SceneManager.LoadScene("Ingredients_Level01");
        }

    }
    public void ExitGameBtn()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
