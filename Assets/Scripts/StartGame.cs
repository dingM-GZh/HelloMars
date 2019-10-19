using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private SceneLoader scene_loader;

    private void Start()
    {
        scene_loader = FindObjectOfType<SceneLoader>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        //throw new NotImplementedException();
        /* int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);*/
        
        scene_loader.LoadNextScene();
    }
}
