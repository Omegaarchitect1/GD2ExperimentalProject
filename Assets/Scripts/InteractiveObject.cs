using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveObject : MonoBehaviour, IInteractive
{

    [SerializeField]
    private string SceneToLoad;
    public void InteractWith()
    {
        Debug.Log($"Player interacted with {gameObject.name}.");
        SceneManager.LoadScene(SceneToLoad);
    }
}
