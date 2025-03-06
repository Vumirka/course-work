using UnityEngine;

public class ToggleFullscreen : MonoBehaviour {
    // Функція для перемикання між повним екраном і віконним режимом
    public void ToggleScreenMode() {
        if (Screen.fullScreen) {
            // Якщо зараз повний екран, переключити в віконний
            Screen.fullScreen = false;
        }
        else {
            // Якщо зараз віконний режим, переключити в повний екран
            Screen.fullScreen = true;
        }
    }
}

