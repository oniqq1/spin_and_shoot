using UnityEngine;

public class Moving_Manager : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private float rotate_camera_speed;

    void Start()
    {
        Application.targetFrameRate = 240;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        Debug.Log(mouseX);
        player.transform.Rotate(new Vector3(0, mouseX * rotate_camera_speed * Time.deltaTime, 0));
    }
}
