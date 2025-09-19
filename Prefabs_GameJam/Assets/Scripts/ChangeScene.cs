using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string scene;

    public void ChangingScene()
    {
        SceneManager.LoadScene(scene);
        AudioManager.Instance.SetMusicClip(scene);
        AudioManager.Instance.PlayMusic();
    }
}
