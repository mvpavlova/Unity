using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class table : MonoBehaviour {

    public bool _paused = false;
    public int _window = 150;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "tabletriger")
            if (!_paused)
            {
                _window = 0;
                _paused = true;
                Time.timeScale = 1;

            }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "tabletriger")
            _window = 150;
            _paused = false;
            
    }
    private void OnGUI()
    {
        if (_window == 0)
        {
            GUI.Box(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 100, 300, 30), "Press E to pick up");
        }
        

    }
}
