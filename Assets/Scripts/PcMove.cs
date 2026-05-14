using UnityEngine;
using UnityEngine.InputSystem; 

public class PcMove : MonoBehaviour
{
    public float speed = 5.0f;
    public float mouseSensitivity = 0.2f; 
    private CharacterController controller;
    private float pitch = 0.0f;
    private float yaw = 0.0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked; 
    }

    void Update()
    {
        if (Keyboard.current == null || Mouse.current == null) return;

        float moveX = 0f;
        float moveZ = 0f;

        if (Keyboard.current.wKey.isPressed) moveZ += 1f;
        if (Keyboard.current.sKey.isPressed) moveZ -= 1f;
        if (Keyboard.current.dKey.isPressed) moveX += 1f;
        if (Keyboard.current.aKey.isPressed) moveX -= 1f;

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * speed * Time.deltaTime);

        Vector2 mouseDelta = Mouse.current.delta.ReadValue();
        
        yaw += mouseDelta.x * mouseSensitivity;
        pitch -= mouseDelta.y * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, -90f, 90f); 

        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        Camera.main.transform.localEulerAngles = new Vector3(pitch, 0.0f, 0.0f);
    }
}