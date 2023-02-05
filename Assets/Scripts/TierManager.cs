using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TierManager : MonoBehaviour
{
    private int reqReputation;
    private int reqPaper;

    public List<GameObject> tierList = new List<GameObject>();

    public TMP_Text tierText;
    public TMP_Text reputationText;
    public TMP_Text paperText;


    void Start() {
        foreach(GameObject gameObject in tierList) {
            gameObject.SetActive(false);
            UpdateArea();
        }
    }
    void Update()
    {
        UpdateRequirements();
        UpdateText();

    }

    public void TryUpgradeTier() {
        if(StaticResources.valueReputation >= reqReputation && StaticResources.valuePublishedPapers >= reqPaper && reqPaper != -1) {
            StaticResources.areaStatus++;
        }
    }

    public void UpdateRequirements() {
        switch(StaticResources.areaStatus) {
            case 0:
            reqReputation = 0;
            reqPaper = 0;
            break;
            case 1:
            reqReputation = 5;
            reqPaper = 0;
            break;
            case 2:
            reqReputation = 100;
            reqPaper = 0;
            break;
            case 3:
            reqReputation = 800;
            reqPaper = 0;
            break;
            case 4:
            reqReputation = 10000;
            reqPaper = 1;
            break;
            case 5:
            reqReputation = 60000;
            reqPaper = 20;
            break;
            case 6:
            reqReputation = 200000;
            reqPaper = 150;
            break;
            case 7:
            reqReputation = 750000;
            reqPaper = 600;
            break;
            case 8:
            reqReputation = 1500000;
            reqPaper = 1400;
            break;
            case 9:
            reqReputation = 4000000;
            reqPaper = 5000;
            break;
            case 10:
            reqReputation = -1;
            reqPaper = -1;
            break;
            case 21:
            reqReputation = -1;
            reqPaper = -1;
            break;
        }
    }

    public void UpdateArea() {
        foreach(GameObject gameObject in tierList) {
            gameObject.SetActive(false);
        }
        for(int i=0; i<=StaticResources.areaStatus; i++) {
            tierList[i].SetActive(true);
        }




    }

    public void UpdateText() {

        tierText.text = "Tier:\n" + StaticResources.areaStatus +"/10";
        if(reqPaper == -1) {
            reputationText.text = "MAX";
            paperText.text = "MAX";
        }
        else {
        reputationText.text = reqReputation.ToString();
        paperText.text = reqPaper.ToString();
        }
    }

}
