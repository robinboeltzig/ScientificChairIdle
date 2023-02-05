using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceSync : MonoBehaviour
{

    public TMP_Text textUSD;
    public TMP_Text textReferences;
    public TMP_Text textReputation;
    public TMP_Text textPublishedPapers;

    // Update is called once per frame
    void Update()
    {

        textUSD.text = StaticResources.valueUSD.ToString("F2");
        textReferences.text = StaticResources.valueReferences.ToString("F2");
        textReputation.text = StaticResources.valueReputation.ToString("F2");
        textPublishedPapers.text = StaticResources.valuePublishedPapers.ToString("F2");
        
    }
}
