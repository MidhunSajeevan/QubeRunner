using UnityEngine;

public class EndTruiger : MonoBehaviour
{
    public GameManager Manager;
    private void OnTriggerEnter()
    {
        Manager.completeLevel();
    }
}
