using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioSource playerSFX;
    public AudioClip noteSFX;
    public AudioClip walkSFX;
    public GameController gameController;
    [SerializeField]
    GameObject interactionUIText;
    public bool isWalking;
    [SerializeField]
    float walkingSpeed = 5;
    [SerializeField]
    float runningSpeed = 10;
    [SerializeField]
    int mouseSensitivity;
    float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftShift))
            isWalking = false;
        else
            isWalking = true;


        if(isWalking) 
            speed = walkingSpeed;
        else
            speed = runningSpeed;
             
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        float cameraRot = Camera.main.transform.rotation.eulerAngles.y;
        rb.position += Quaternion.Euler(0, cameraRot, 0) * input * speed * Time.fixedDeltaTime;
    }

    private void OnTriggerStay(Collider other) {
        if(other.gameObject.CompareTag("Note"))
        {
            interactionUIText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                playerSFX.PlayOneShot(noteSFX);
                Destroy(other.gameObject);
                gameController.numberOfNotes += 1;
                interactionUIText.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("Note"))
        {
            interactionUIText.SetActive(false);
        }
    }
}
