using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] int sceneNumber;

    public void LoadSceneOnClick()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
