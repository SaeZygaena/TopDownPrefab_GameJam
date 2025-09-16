using UnityEngine;

public class SaveHome : MonoBehaviour
{
    public static SaveHome Instance;

    public bool isHome = false;
    void Start()
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
}
