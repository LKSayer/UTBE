using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathLogic : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
          GetComponent<MeshRenderer>().enabled = false;
          GetComponent<Rigidbody>().isKinematic = true;
          GetComponent<CapsuleCollider>().enabled = false;
          Invoke(nameof(ReloadLevel), 1.3f);
        }
    }
    

    void ReloadLevel()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
