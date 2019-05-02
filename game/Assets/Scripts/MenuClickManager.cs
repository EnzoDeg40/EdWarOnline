using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuClickManager : MonoBehaviour {

    public GameObject ButtonMenu; 
    public GameObject ButtonMultiplayer;

    public GameObject FindGame;
    public GameObject CreateGame;

    public GameObject MenuExpertManager;

    public GameObject ButtonBackFind;

    public void ButtonClickTutoriel()
    {
        SceneManager.LoadScene("Tutoriel");
    }

    public void ButtonClickFirstMap()
    {
        //SceneManager.LoadScene("MainLevel02");
        SceneManager.LoadScene("MainLevel02", LoadSceneMode.Additive);
    }

    public void ButtonClickDesertMap()
    {
        SceneManager.LoadScene("MainLevel03");
    }

    public void ButtonClickMultiplayer()
    {
        ButtonMenu.SetActive(false);
        ButtonMultiplayer.SetActive(true);
    }

    public void ButtonClickFindGame()
    {
        ButtonMenu.SetActive(false);
        ButtonMultiplayer.SetActive(false);

        FindGame.SetActive(true);

        ButtonBackFind.SetActive(true);
    }

    public void ButtonClickCreateGame()
    {
        ButtonMenu.SetActive(false);
        ButtonMultiplayer.SetActive(false);

        CreateGame.SetActive(true);

        ButtonBackFind.SetActive(true);
    }

    public void ButtonExManGame()
    {
        ButtonMultiplayer.SetActive(false);
        MenuExpertManager.SetActive(true);
    }

    public void BackExManGame()
    {
        ButtonMultiplayer.SetActive(true);
        MenuExpertManager.SetActive(false);
    }

    public void Back()
    {
        ButtonMultiplayer.SetActive(false);
        ButtonMenu.SetActive(true);
    }

    public void BackMultiplayer()
    {
        ButtonBackFind.SetActive(false);

        FindGame.SetActive(false);
        CreateGame.SetActive(false);
        ButtonMultiplayer.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
