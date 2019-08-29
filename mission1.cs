using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mission1 : MonoBehaviour {

    public bool _paused = false;
    public int _window = 150;
    
      
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "treetriger")
                if (!_paused)
            {
                _window = 0;
                _paused = true;
                Time.timeScale = 1;
                                    
            }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "treetriger")
            _window = 150;
            _paused = false;
            
       


    }
    private void OnGUI()
    {
        GUI.skin.box.wordWrap = true;
        if (_window == 0)
        {
            GUI.Box(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 150, 300, 300), "Well done. Now we must go to the house.");
            GUI.Box(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 0, 300, 150), "Молодец. Теперь надо подойти к дому.");
        }
        
    }
   
   
}


