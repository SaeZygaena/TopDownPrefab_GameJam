using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    private TextMeshProUGUI textMP;
    void Start()
    {
        textMP = GetComponent<TextMeshProUGUI>();

        if (!SaveHome.Instance.isHome)
        {
            textMP.text = "MR BLUE JUST WANTS TO GET HOME!";
        }
        else
        {
            textMP.text = "MR BLUE IS HOME!";
        }
    }
}
