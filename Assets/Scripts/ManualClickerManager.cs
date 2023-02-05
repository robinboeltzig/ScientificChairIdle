using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualClickerManager : MonoBehaviour
{

    public AutoResourceHandler autoResourceHandler;

    public void DoFarmPaper() {
        StaticResources.valueReferences += 0.1f+autoResourceHandler.totalWorkForce;
    }

    public void DoLookForFunding() {
        StaticResources.valueUSD += 0.1f+autoResourceHandler.totalWorkForce;
    }

    public void DoManageSocialMedia() {
        StaticResources.valueReputation += 0.1f +autoResourceHandler.totalWorkForce;
    }

    void Update() {

    }

}
