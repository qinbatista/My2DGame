using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
        string clickedObj = EventSystem.current.currentSelectedGameObject.name;
        int selectedIndex = int.Parse(clickedObj);
        GameManager.instance.CharIndex = selectedIndex;
        SceneManager.LoadScene("GamePlay");
    }
}
