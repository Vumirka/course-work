using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsManager : MonoBehaviour {
    public AudioSource musicSource; // Аудіо для фонової музики
    public AudioSource effectsSource; // Аудіо для звуків ефектів

    public Slider masterVolumeSlider; // Повзунок для загальної гучності
    public Slider musicVolumeSlider; // Повзунок для гучності музики
    public Slider effectsVolumeSlider; // Повзунок для гучності ефектів

    private void Start() {
        // Ініціалізація значень повзунків
        masterVolumeSlider.onValueChanged.AddListener(SetMasterVolume);
        musicVolumeSlider.onValueChanged.AddListener(SetMusicVolume);
        effectsVolumeSlider.onValueChanged.AddListener(SetEffectsVolume);

        // Встановлюємо початкові значення гучності
        SetMasterVolume(masterVolumeSlider.value);
        SetMusicVolume(musicVolumeSlider.value);
        SetEffectsVolume(effectsVolumeSlider.value);
    }

    // Функція для зміни загальної гучності
    public void SetMasterVolume(float volume) {
        AudioListener.volume = volume; // Загальна гучність гри
    }

    // Функція для зміни гучності фонової музики
    public void SetMusicVolume(float volume) {
        musicSource.volume = volume * AudioListener.volume; // Гучність музики з врахуванням загальної
    }

    // Функція для зміни гучності звуків ефектів
    public void SetEffectsVolume(float volume) {
        effectsSource.volume = volume * AudioListener.volume; // Гучність ефектів з врахуванням загальної
    }
}
