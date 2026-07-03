using UnityEngine;

/// <summary>
/// Camera bám theo mục tiêu một cách mượt mà. Gắn vào Main Camera,
/// kéo Player vào ô Target.
/// </summary>
public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.15f;
    public Vector3 offset = new Vector3(0f, 0f, -10f); // giữ camera phía trước mặt phẳng 2D

    Vector3 velocity;

    void LateUpdate()
    {
        if (target == null) return;
        Vector3 goal = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, goal, ref velocity, smoothTime);
    }
}
