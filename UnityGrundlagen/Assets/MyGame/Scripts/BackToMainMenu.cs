using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            // Lade die erste Scene im Build Index
            SceneManager.LoadScene(0);
	    // Mouse zeiger aktivieren
	    Cursor.lockState = CursorLockMode.None;
        }
    }
}
