using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private GameObject uiNextLevel;
    
    public void LoadingScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnTriggerEnter(Collider other)
    {
        uiNextLevel.SetActive(true);
        other.gameObject.SetActive(false);
    }

    
}
