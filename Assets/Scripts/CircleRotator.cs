using UnityEngine;

public class CircleRotator : MonoBehaviour
{
    public Transform circle;

    void Update()
    {
        circle.Rotate(Vector3.forward * 10 * Time.deltaTime);
    }
}
