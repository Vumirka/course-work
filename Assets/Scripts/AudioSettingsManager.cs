using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsManager : MonoBehaviour {
    public AudioSource musicSource; 
    public AudioSource effectsSource; 

    public Slider masterVolumeSlider; 
    public Slider musicVolumeSlider; 
    public Slider effectsVolumeSlider; 

    private void Start() {
        
        masterVolumeSlider.onValueChanged.AddListener(SetMasterVolume);
        musicVolumeSlider.onValueChanged.AddListener(SetMusicVolume);
        effectsVolumeSlider.onValueChanged.AddListener(SetEffectsVolume);

       
        SetMasterVolume(masterVolumeSlider.value);
        SetMusicVolume(musicVolumeSlider.value);
        SetEffectsVolume(effectsVolumeSlider.value);
    }

   
    public void SetMasterVolume(float volume) {
        AudioListener.volume = volume; 
    }

    
    public void SetMusicVolume(float volume) {
        musicSource.volume = volume * AudioListener.volume; 
    }

    
    public void SetEffectsVolume(float volume) {
        effectsSource.volume = volume * AudioListener.volume; 
}
