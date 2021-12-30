using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadCollision : MonoBehaviour
{
    [SerializeField] float RestartTime;
    void OnCollisionEnter2D(Collision2D other) 
    {
        SceneManager.LoadScene(0);
    }
}
