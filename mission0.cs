using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mission0 : MonoBehaviour
{

    public bool _paused = false;
    public int _window = 150;
    public float timer = 300;
    GUIContent content;
    GUIContent contentrus;
    public GameObject lose;

    void Start()
    {
        content = new GUIContent("Hello my friend. Today you need to pass the test. Let's start the exercises. You need to go to the tree.");
        contentrus = new GUIContent("Здравствуй друг. Cегодня тебе надо пройти тест. Давай начнем упражнения.Тебе необходимо подойти к дереву.");
        lose = GameObject.Find("lose");
    }
    private void Update()
    {
        if (timer > 0)
        {
            timer -= 1f;
            if (timer == 0)
            {
                lose.GetComponent<lose>().gameover();
                OnGUI();
                
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "starttriger")
            if (!_paused)
            {
                _window = 0;
                _paused = true;
                Time.timeScale = 1;

            }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "starttriger")
            _window = 150;
        _paused = false;
        timer = 500f;



    }
    private void OnGUI()
    {

        if (_window == 0)
        {
            GUI.skin.box.wordWrap = true;
            GUI.Box(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 150, 300, 300), content);
            GUI.Box(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 0, 300, 150), contentrus);
        }
        if (timer == 0)
        {
            
            GUI.Box(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 150, 300, 300), "You lose. Start the test again");
            if (GUI.Button(new Rect(Screen.width / 2 - 140, Screen.height / 2 - 30, 280, 30), "Start Again"))
            {
                Time.timeScale = 1;
                _paused = true;
                _window = 150;
                SceneManager.LoadScene(0);
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 140, Screen.height / 2 + 30, 280, 30), "Exit"))
            { Application.Quit(); }
            

        }

    }
}
    
