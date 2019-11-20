using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    public UnityEngine.UI.Image image;

    int counter = 0;
    

    // Start is called before the first frame update
    public void OnClick()
    {
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void loadGarage()
    {
        SceneManager.LoadScene("Garage");
    }
    public void loadSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void changeColor()
    {
        image.color = Color.black;
        counter++;
        if(counter == 3)
        {
            image.color = Color.white;
            counter = 0;
        }
        
    }


}
