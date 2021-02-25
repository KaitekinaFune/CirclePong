using UnityEngine;

public class CircleRotator : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 0, 1 * Time.deltaTime);
    }
}
