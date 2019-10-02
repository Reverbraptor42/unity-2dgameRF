using UnityEngine;

public class HazardSpinner : MonoBehaviour
{
    public Transform pivot;

   
    public float speed;
    private void Update()
    {
        pivot.Rotate(Vector3.back * speed);
    }
}
