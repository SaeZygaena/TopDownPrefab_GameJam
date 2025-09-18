using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using Unity.VisualScripting;
using System.Data.Common;

public class Transition : MonoBehaviour
{
    public static Transition Instance;
    public GameObject Left;
    public GameObject Right;

    public float savePostLeft;
    public float savePostRight;
    private bool isEnable = false;

    private float direction = 1;
    void Start()
    {
        if (!Instance)
        {
            savePostLeft = Left.transform.localPosition.x;
            savePostRight = Right.transform.localPosition.x;

            Debug.Log("Left = " + savePostLeft);
            Debug.Log("Right = " + savePostRight);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void EnableTransition(string _sceneName)
    {
        isEnable = true;
        StartCoroutine(TransitionStart(_sceneName));
    }

    void Update()
    {
        if (isEnable)
        {
            if (direction == 1)
            {
                if (Left.transform.position.x < 25)
                    Left.transform.position += new Vector3(0.1f, 0, 0) * direction;
                if (Right.transform.position.x > -5)
                    Right.transform.position += new Vector3(-0.1f, 0, 0) * direction;
            }
            else if (direction == -1)
            {
                if (Left.transform.position.x != savePostLeft)
                    Left.transform.position += new Vector3(0.5f, 0, 0) * direction;
                if (Right.transform.position.x != -savePostRight)
                    Right.transform.position += new Vector3(-0.5f, 0, 0) * direction;
            }
        }
    }

    IEnumerator TransitionStart(string _sceneName)
    {
        yield return new WaitForSeconds(2f);
        isEnable = false;
        direction = -1;
        SceneManager.LoadScene(_sceneName);
        StartCoroutine(TransitionEnd());
    }

    IEnumerator TransitionEnd()
    {
        yield return new WaitForSeconds(0.5f);
        isEnable = true;
        yield return new WaitForSeconds(3f);
        isEnable = false;
        direction = 1;
    }
   
}
