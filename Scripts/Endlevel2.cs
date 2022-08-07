using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endlevel2 : MonoBehaviour
{
    public string level3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hi");
            SceneManager.LoadScene(level3);
        }

    }
}

