using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButtonScript : MonoBehaviour
{
    public bool isActive = false;

    private void OnMouseDown()
    {
        if (isActive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
