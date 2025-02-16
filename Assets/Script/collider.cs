using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Slime")
        {
            Debug.Log("Switch"); 
            SceneManager.LoadScene(2);
        }
    }
}
