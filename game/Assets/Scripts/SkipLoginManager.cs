using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipLoginManager : MonoBehaviour {

	public void SkipLogin()
    {
        SceneManager.LoadScene("Lobby");
    }
}
