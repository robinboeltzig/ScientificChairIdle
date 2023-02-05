using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkerAndBoostManager : MonoBehaviour
{
    public List<TMP_Text> textList = new List<TMP_Text>();
    public List<TMP_Text> costList = new List<TMP_Text>();
    public List<float> costCreepList = new List<float> {0, 0, 0, 0, 0, 0, 0, 0};
    public List<int> maxList = new List<int>();

    public float creepFactor = 1.2f;
    public List<int> curList = new List<int> {StaticResources.valueIntern, StaticResources.valueStudent, StaticResources.valuePhDCandidate, StaticResources.valueResearcher, StaticResources.valueResearchAI, StaticResources.valueBeverage, StaticResources.valuePC, StaticResources.valueServer};
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        curList = new List<int> {StaticResources.valueIntern, StaticResources.valueStudent, StaticResources.valuePhDCandidate, StaticResources.valueResearcher, StaticResources.valueResearchAI, StaticResources.valueBeverage, StaticResources.valuePC, StaticResources.valueServer};
        UpdateWorkerAndBoosts();
        UpdateDescriptions();
        UpdateCosts();

    }

    public void UpdateWorkerAndBoosts() {
        switch(StaticResources.areaStatus) {
            case 0:
            maxList = new List<int> {0, 0, 0, 0, 0, 0, 0, 0};
            break;
            case 1:
            maxList = new List<int> {0, 0, 0, 0, 0, 0, 0, 0};
            break;
            case 2:
            maxList = new List<int> {2, 0, 0, 0, 0, 0, 0, 0};
            break;
            case 3:
            maxList = new List<int> {5, 2, 0, 0, 0, 3, 0, 0};
            break;
            case 4:
            maxList = new List<int> {8, 5, 1, 0, 0, 5, 0, 0};
            break;
            case 5:
            maxList = new List<int> {12, 8, 2, 0, 0, 8, 2, 0};
            break;
            case 6:
            maxList = new List<int> {20, 12, 5, 1, 0, 10, 4, 0};
            break;
            case 7:
            maxList = new List<int> {30, 20, 8, 2, 0, 15, 8, 2};
            break;
            case 8:
            maxList = new List<int> {45, 30, 12, 5, 1, 22, 14, 5};
            break;
            case 9:
            maxList = new List<int> {65, 45, 18, 8, 2, 30, 20, 12};
            break;
            case 10:
            maxList = new List<int> {100, 75, 25, 10, 5, 50, 30, 20};
            break;
        }
    }

    public void UpdateDescriptions() {
        for(int i=0; i<=7; i++) {
            textList[i].text = curList[i]+"/"+maxList[i];
        }
    }

    public void UpdateCosts() {
        for(int i=0; i<=7; i++) {
            costList[i].text = StaticResources.staticCosts[i]+"$";
        }
    }

    public void CalculateCosts() {
        for(int i=0; i<=7; i++) {
            switch(i) {
                case 0:
                costCreepList[i] = StaticResources.staticCosts[i]*Mathf.Pow(creepFactor, StaticResources.valueIntern);
                break;
                case 1:
                costCreepList[i] = StaticResources.staticCosts[i]*Mathf.Pow(creepFactor, StaticResources.valueStudent);
                break;
                case 2:
                costCreepList[i] = StaticResources.staticCosts[i]*Mathf.Pow(creepFactor, StaticResources.valuePhDCandidate);
                break;
                case 3:
                costCreepList[i] = StaticResources.staticCosts[i]*Mathf.Pow(creepFactor, StaticResources.valueResearcher);
                break;
                case 4:
                costCreepList[i] = StaticResources.staticCosts[i]*Mathf.Pow(creepFactor, StaticResources.valueResearchAI);
                break;
                case 5:
                costCreepList[i] = StaticResources.staticCosts[i]*Mathf.Pow(creepFactor, StaticResources.valueBeverage);
                break;
                case 6:
                costCreepList[i] = StaticResources.staticCosts[i]*Mathf.Pow(creepFactor, StaticResources.valuePC);
                break;
                case 7:
                costCreepList[i] = StaticResources.staticCosts[i]*Mathf.Pow(creepFactor, StaticResources.valueServer);
                break;
            }
        }
    }

    public void BuyOneItem(int index) {
        if(StaticResources.valueUSD >= StaticResources.staticCosts[index] && curList[index] < maxList[index]) {
            StaticResources.valueUSD -= StaticResources.staticCosts[index];
            switch(index) {
                case 0:
                StaticResources.valueIntern ++;
                break;
                case 1:
                StaticResources.valueStudent ++;
                break;
                case 2:
                StaticResources.valuePhDCandidate ++;
                break;
                case 3:
                StaticResources.valueResearcher ++;
                break;
                case 4:
                StaticResources.valueResearchAI ++;
                break;
                case 5:
                StaticResources.valueBeverage ++;
                break;
                case 6:
                StaticResources.valuePC ++;
                break;
                case 7:
                StaticResources.valueServer ++;
                break;

            }
        }
    }

    public void BuyTenItems(int index) {
        if(StaticResources.valueUSD >= StaticResources.staticCosts[index] * 10 && (curList[index] +10) < maxList[index]) {
            StaticResources.valueUSD -= StaticResources.staticCosts[index] * 10;
            switch(index) {
                case 0:
                StaticResources.valueIntern +=10;
                break;
                case 1:
                StaticResources.valueStudent +=10;
                break;
                case 2:
                StaticResources.valuePhDCandidate +=10;
                break;
                case 3:
                StaticResources.valueResearcher +=10;
                break;
                case 4:
                StaticResources.valueResearchAI +=10;
                break;
                case 5:
                StaticResources.valueBeverage +=10;
                break;
                case 6:
                StaticResources.valuePC +=10;
                break;
                case 7:
                StaticResources.valueServer +=10;
                break;

            }
        }
    }

    


    

}
