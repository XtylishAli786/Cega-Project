using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 Offset;  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
       transform.position = player.position + Offset;
    }
}
