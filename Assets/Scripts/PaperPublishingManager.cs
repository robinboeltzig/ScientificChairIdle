using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PaperPublishingManager : MonoBehaviour
{
    public List<Sprite> imgList = new List<Sprite>();

    public TMP_Dropdown dropdown;

    public TMP_InputField input;
    public Image image;

    public TMP_Text oddsText;

    public float odds;



    void Start()
    {
        dropdown.value = StaticResources.publishingType;
        input.text = StaticResources.allocateResources.ToString();

        OnDropdown(dropdown.value);


    }

    // Update is called once per frame
    void Update()
    {
        UpdateOdds();
    }

    public void OnDropdown(int value) {
        image.sprite = imgList[value];
    }

    public void SaveDropdown(int value) {
        StaticResources.publishingType = value;
    }

    public void SaveInput(string input) {
        if(Int32.TryParse(input, out int ignore)) {
            StaticResources.allocateResources = Int32.Parse(input);
        }
    }
    public float CalculateSigmoid(float input, float middle) {
        return 1/(1 + Mathf.Exp(-((input*(5/middle))-5)));
    }

    public void UpdateOdds() {
        odds = CalculateSigmoid(StaticResources.allocateResources, StaticResources.staticSigmoid[StaticResources.publishingType]);

        oddsText.text = odds*100+"%";

    }

    public void TrySubmit() {
        if(StaticResources.valueReferences>=StaticResources.allocateResources) {
            StaticResources.valueReferences = StaticResources.valueReferences- StaticResources.allocateResources;
            if(odds>UnityEngine.Random.Range(0f, 1f)) {
                StaticResources.valuePublishedPapers += StaticResources.staticPaper[StaticResources.publishingType];
            }
        }
    }

}
