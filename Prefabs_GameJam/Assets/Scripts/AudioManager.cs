using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource audioSource;
    public AudioClip menuClip;
    public AudioClip homeClip;
    public AudioClip oneClip;
    public AudioClip twoClip;
    public AudioClip threeClip;
    public AudioClip fourClip;
    public AudioClip fiveClip;
    public AudioClip sixClip;
    public AudioClip sevenClip;
    public AudioClip eightClip;

    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void SetMusicClip(string _scene)
    {
        audioSource.clip = menuClip;

        string sceneName = _scene;

        switch (sceneName)
        {
            case "Home_Scene":
                audioSource.clip = homeClip;
                break;
            case "Title_Scene":
                audioSource.clip = menuClip;
                break;
            case "Level_One":
                audioSource.clip = oneClip;
                break;
            case "Level_Two":
                audioSource.clip = twoClip;
                break;
            case "Level_Three":
                audioSource.clip = threeClip;
                break;
            case "Level_Four":
                audioSource.clip = fourClip;
                break;
            case "Level_Five":
                audioSource.clip = fiveClip;
                break;
            case "Level_Six":
                audioSource.clip = sixClip;
                break;
            case "Level_Seven":
                audioSource.clip = sevenClip;
                break;
            case "Level_Eight":
                audioSource.clip = eightClip;
                break;
            default:
                break;
        }
    }

    public void PlayMusic()
    {
        
        audioSource.Play();
    }

}
