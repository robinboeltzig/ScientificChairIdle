using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BackgroundSwitcher : MonoBehaviour
{

public Image backgroundImage;
public List<Sprite> imgList = new List<Sprite>();


    public void Start() {
        
        SwitchToBackground("MainMenu");
    }

public void SwitchToBackground(string ImageName) {

    backgroundImage.sprite = imgList.Find((x) => x.name == "BG_"+ ImageName);

}

}
