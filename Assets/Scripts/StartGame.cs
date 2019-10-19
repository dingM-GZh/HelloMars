using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private SceneLoader scene_loader;
    private bool is_loaded = false;

    private void Start()
    {
        scene_loader = FindObjectOfType<SceneLoader>();
        Debug.Log("FOUND SCENE LOADER");
    }

    private void Update()
    {
        //throw new NotImplementedException();
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        //throw new NotImplementedException();
        /* int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);*/
        //Debug.Log("TRIGGER");
        if (!is_loaded && collider.gameObject.CompareTag("glasses") )
        {
            Debug.Log("CHANGE SCENE");
            scene_loader.LoadNextScene();
            is_loaded = true;
        }
        else
        {
            Debug.Log("ALREADY LOADED");
        }
        
    }
}
