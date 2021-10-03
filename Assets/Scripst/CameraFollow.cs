using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject targetObject;
    public Vector3 cameraOffset;
    public Vector3 targettedPozition;
    private Vector3 velocity = Vector3.zero;

    public float smothTime;
    void Update()
    {
        targettedPozition = targetObject.transform.position + cameraOffset;

        transform.position = Vector3.SmoothDamp(transform.position, targettedPozition, ref velocity, smothTime);

    }
}
