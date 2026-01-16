using KrToys;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivity = 200f;
    private float xRotation = 0f;
    public float smoothTime = 0.05f; 
    public float xVelocity = 0f;
    public Transform Player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        xRotation = 0f;

        transform.localRotation = Quaternion.identity;
        Player.rotation = Quaternion.identity;
    }

    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        
        float smoothX = Mathf.SmoothDampAngle(transform.localEulerAngles.x, xRotation, ref xVelocity, smoothTime);

        transform.localRotation = Quaternion.Euler(smoothX, 0f, 0f);
        
        Player.Rotate(Vector3.up * mouseX);

        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}