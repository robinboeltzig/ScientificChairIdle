using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BackgroundSwitcher : MonoBehaviour
{

public Image backgroundImage;
public List<Sprite> imgList = new List<Sprite>();
public List<GameObject> panelList = new List<GameObject>();

    public Button quitButton;


    public void Start() {
        
        SwitchToBackground("MainMenu");
        if(Application.platform == RuntimePlatform.WebGLPlayer)
        {
            quitButton.enabled = false;
        }
    }

public void SwitchToBackground(string ImageName) {

    backgroundImage.sprite = imgList.Find((x) => x.name == "BG_"+ ImageName);

}

public void SwitchToPanel(string PanelName) {
    foreach(GameObject gameObject in panelList) {
        if(gameObject.name == PanelName) {
           gameObject.SetActive(true); 
        }
        else {
            gameObject.SetActive(false); 
        }
    }
}

public void SwitchBackgroundAndPanel(string Name) {
    SwitchToBackground(Name);
    SwitchToPanel(Name);
}

public void ToggleOptions() {
    if(panelList.Find((x) => x.name == "Options").activeSelf) {
        SwitchBackgroundAndPanel("MainMenu");
    }
    else {
        SwitchBackgroundAndPanel("Options");
    }
}

public void QuitGame() {
    Application.Quit();
}


}
