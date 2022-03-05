using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Note : MonoBehaviour
{
    public AudioSource audioManager;
    public GameController gameController;
    [SerializeField]
    GameObject interactionUIText;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if(other.gameObject.CompareTag("Player"))
        {
            interactionUIText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                audioManager.Play();
                Destroy(gameObject);
                gameController.numberOfNotes += 1;
                interactionUIText.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("Player"))
        {
            interactionUIText.SetActive(false);
        }
    }
}
