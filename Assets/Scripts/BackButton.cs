using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {
    public void BackToMenu() {
        // ����������� ����� "MainMenu"
        SceneManager.LoadScene("MainMenu");
    }
}
