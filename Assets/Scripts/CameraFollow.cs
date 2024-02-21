using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 5f; // Distance from the player
    public float height = 2f;   // Height above the player
    public float rotationDamping = 5f; // Smoothness of camera rotation

    private void LateUpdate()
    {
        if (target == null)
            return;

        // Calculate the desired position
        Vector3 desiredPosition = target.position - target.forward * distance + Vector3.up * height;

        // Smoothly move the camera towards the desired position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * rotationDamping);

        // Calculate the direction the player is moving
        Vector3 movementDirection = target.forward;

        // Calculate the target rotation based on the movement direction
        Quaternion targetRotation = Quaternion.LookRotation(movementDirection);

        // Smoothly rotate the camera towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationDamping * Time.deltaTime);
    }
}
