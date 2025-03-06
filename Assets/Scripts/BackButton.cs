using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {
    public void BackToMenu() {
        // Завантажуємо сцену "MainMenu"
        SceneManager.LoadScene("MainMenu");
    }
}
