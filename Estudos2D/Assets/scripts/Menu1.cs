using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour
{
    public string cena;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(cena);
    }

    public void QuitGame()
    {
        //Editor Unity
        UnityEditor.EditorApplication.isPlaying = false;
        //Game compilado
        //Application.Quit();
    }
}
