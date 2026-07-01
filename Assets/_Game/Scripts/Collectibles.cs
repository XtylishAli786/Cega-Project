using TMPro;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
 public float rotationSpeed = 50f;
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
  


}