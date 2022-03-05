using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject JumpscareUI;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ShowUI", 3f);
    }

    void ShowUI()
    {
        JumpscareUI.SetActive(true);
    } 
}
