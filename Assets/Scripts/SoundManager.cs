using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;
    public AudioSource musicSource;


void Awake()
{ 
        if(instance == null) 
    {  
            instance = this; 
    }
        
        else if (instance != this) 
    {
            Destroy(gameObject);
    }

        DontDestroyOnLoad(gameObject);
}
}

