using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectDestroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (collision.CompareTag("CubeSliding"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else
            Destroy(collision.gameObject);
    }
}
