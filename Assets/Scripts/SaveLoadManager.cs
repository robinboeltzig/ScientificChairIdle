using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    private void Awake() {
        LoadAll();
    }

    private void Update() {

        SaveAll();
    }  


    public void LoadAll() {

        //Resources
        StaticResources.valueUSD = PlayerPrefs.GetFloat("valueUSD", 0);
        StaticResources.valueReferences = PlayerPrefs.GetFloat("valueReferences", 0);
        StaticResources.valueReputation = PlayerPrefs.GetFloat("valueReputation", 0);
        StaticResources.valuePublishedPapers = PlayerPrefs.GetFloat("valuePublishedPapers", 0);

        //AreaStatus
        StaticResources.areaStatus = PlayerPrefs.GetInt("areaStatus", 0);

        //AutomationUnits

        StaticResources.valueIntern= PlayerPrefs.GetInt("valueIntern", 0);
        StaticResources.valueStudent= PlayerPrefs.GetInt("valueStudent", 0);
        StaticResources.valuePhDCandidate= PlayerPrefs.GetInt("valuePhDCandidate", 0);
        StaticResources.valueResearcher= PlayerPrefs.GetInt("valueResearcher", 0);
        StaticResources.valueResearchAI= PlayerPrefs.GetInt("valueResearchAI", 0);

        //AutomationAllocation

        StaticResources.percentUSD = PlayerPrefs.GetFloat("percentUSD", 0);
        StaticResources.percentReferences = PlayerPrefs.GetFloat("percentReferences", 0);
        StaticResources.percentReputation = PlayerPrefs.GetFloat("percentReputation", 0);

        //Boosts
        StaticResources.valueBeverage= PlayerPrefs.GetInt("valueBeverage", 0);
        StaticResources.valuePC= PlayerPrefs.GetInt("valuePC", 0);
        StaticResources.valueServer= PlayerPrefs.GetInt("valueServer", 0);

    }

    public void SaveAll() {
        //Resources
        PlayerPrefs.SetFloat("valueUSD", StaticResources.valueUSD);
        PlayerPrefs.SetFloat("valueReferences", StaticResources.valueReferences);
        PlayerPrefs.SetFloat("valueReputation", StaticResources.valueReputation);
        PlayerPrefs.SetFloat("valuePublishedPapers", StaticResources.valuePublishedPapers);

        //AreaStatus

        PlayerPrefs.SetInt("areaStatus", StaticResources.areaStatus);

        //AutomationUnits
        PlayerPrefs.SetInt("valueIntern", StaticResources.valueIntern);
        PlayerPrefs.SetInt("valueStudent", StaticResources.valueStudent);
        PlayerPrefs.SetInt("valuePhDCandidate", StaticResources.valuePhDCandidate);
        PlayerPrefs.SetInt("valueResearcher", StaticResources.valueResearcher);
        PlayerPrefs.SetInt("valueResearchAI", StaticResources.valueResearchAI);

        //AutomationAllocation
        PlayerPrefs.SetFloat("percentUSD", StaticResources.percentUSD);
        PlayerPrefs.SetFloat("percentReferences", StaticResources.percentReferences);
        PlayerPrefs.SetFloat("percentReputation", StaticResources.percentReputation);

        //Boosts
        PlayerPrefs.SetInt("valueBeverage", StaticResources.valueBeverage);
        PlayerPrefs.SetInt("valuePC", StaticResources.valuePC);
        PlayerPrefs.SetInt("valueServer", StaticResources.valueServer);


        PlayerPrefs.Save();
    }


}
