using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endlevel : MonoBehaviour
{
    public string level2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hi");
            SceneManager.LoadScene(level2);
        }

    }
}
