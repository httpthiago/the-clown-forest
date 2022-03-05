using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    float mouseSensitivity;

    float mouseX = 0.0f, mouseY = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0)
        {
            return;
        }
        mouseX += Input.GetAxis("Mouse X") * mouseSensitivity;
        mouseY += Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.eulerAngles = new Vector3(Mathf.Clamp(-mouseY, -90, 90), mouseX, 0);
    }
}
