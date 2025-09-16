using System.Data.Common;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TriggerObject : MonoBehaviour
{
    // Les UnityEvents permettent de relier des fonctions en passant par l'éditeur dirrectement. Le type d'objet qui vas etre passer est déterminer presentre entre les <>
    public UnityEvent<GameObject> OnTriggerEnterEvent;
    public UnityEvent<GameObject> OnTriggerExitEvent;
    public UnityEvent<GameObject> OnTriggerNextLevel;
    public UnityEvent<GameObject> OnTriggerSpeedUp;

    public int id = 0;


    void OnTriggerEnter2D(Collider2D collision)
    {
        // "OnTriggerEnterEvent?" est équivaux a écrire if(OnTriggerEnterEvent != null) {...} 
        // On fait cette verification car unity enveras une érreur si on essaye d'appeler l'event alors que rien c'est lier a l'event


        if (collision.CompareTag("Player"))
        {
            OnTriggerEnterEvent?.Invoke(collision.gameObject);

            if (id == 2)
            {
                Destroy(gameObject);
                OnTriggerSpeedUp?.Invoke(collision.gameObject);
            }



        }
        if (collision.CompareTag("Trash"))
        {
            if (SceneManager.GetActiveScene().name == "Home_Scene")
                SaveHome.Instance.isHome = true;

            OnTriggerNextLevel?.Invoke(collision.gameObject);
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        OnTriggerExitEvent?.Invoke(collision.gameObject);
    }
}
