using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    [SerializeField] 
    float smoothing = 0.2f;

    private void FixedUpdate()
    {
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
    }
}