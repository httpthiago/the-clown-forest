using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int numberOfNotes = 0;
    public TMP_Text numberOfNotesText;

    private void Update() {
        numberOfNotesText.text = "Notes: " + numberOfNotes.ToString() + "/10";
        if(numberOfNotes == 10)
        {
            SceneManager.LoadScene("WinGame");
        }
    }

    // public void PickUpNote()
    // {
    //     numberOfNotes +=1;
    // }
}
