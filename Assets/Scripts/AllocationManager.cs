using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AllocationManager : MonoBehaviour
{
    public Slider sliderPaper;
    public Slider sliderFunding;
    public Slider sliderSocial;

    public TMP_Text textPaper;
    public TMP_Text textFunding;
    public TMP_Text textSocial;
    

    void Start() {
        sliderPaper.value = StaticResources.percentReferences;
        sliderFunding.value = StaticResources.percentUSD;
        sliderSocial.value = StaticResources.percentReputation;
    }
    void Update()
    {
        sliderPaper.maxValue = 100 - (sliderFunding.value + sliderSocial.value);
        sliderFunding.maxValue = 100 - (sliderPaper.value + sliderSocial.value);
        sliderSocial.maxValue = 100 - (sliderPaper.value + sliderFunding.value);

        textPaper.text = sliderPaper.value+"%";
        textFunding.text = sliderFunding.value+"%";
        textSocial.text = sliderSocial.value+"%";

        StaticResources.percentReferences = sliderPaper.value;
        StaticResources.percentUSD = sliderFunding.value;
        StaticResources.percentReputation = sliderSocial.value;
   }
}
