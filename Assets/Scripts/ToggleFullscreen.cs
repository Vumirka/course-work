using UnityEngine;

public class ToggleFullscreen : MonoBehaviour {
    
    public void ToggleScreenMode() {
        if (Screen.fullScreen) {
            
            Screen.fullScreen = false;
        }
        else {
            
            Screen.fullScreen = true;
        }
    }
}

