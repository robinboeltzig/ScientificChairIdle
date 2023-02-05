using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualClickerManager : MonoBehaviour
{

    public void DoFarmPaper() {
        StaticResources.valueReferences += 0.05f;
    }

    public void DoLookForFunding() {
        StaticResources.valueUSD += 0.05f;
    }

    public void DoManageSocialMedia() {
        StaticResources.valueReputation += 0.05f;
    }
}
