
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
   
    public Transform player;
    public TextMeshProUGUI textMeshPro;
    void Update()
    {
        textMeshPro.text = player.position.z.ToString("0");

    }
}
