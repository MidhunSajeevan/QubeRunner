using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EndTruiger : MonoBehaviour
{
    public GameManager Manager;
    private void OnTriggerEnter(Collider other)
    {
          Manager.completeLevel(other.transform.gameObject.GetComponentInChildren<Text>().text);
    }
}
