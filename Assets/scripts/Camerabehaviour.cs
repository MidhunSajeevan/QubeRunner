using UnityEngine;

public class Camerabehaviour : MonoBehaviour
{
     public Transform player;
      public Vector3 offset;
    //private void Awake()
    //{
    //    player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    //}
    void Update()
    {
        transform.position=player.position + offset;
    
    }
}
