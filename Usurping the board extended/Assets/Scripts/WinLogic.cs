using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLogic : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("King"))
        {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);      
        }
    }
}
