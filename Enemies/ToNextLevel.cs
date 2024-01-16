using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check for a button press, for example, the 'Y' key
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("Player has pressed the button to go to the next level");
            CompleteLevel();
        }
    }

    private void CompleteLevel()
    {
        // Load the next scene in the build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
