using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoResourceHandler : MonoBehaviour
{
    public float totalWorkForce;

    public float internPower = 0.1f;
    public float studentPower = 0.8f;
    public float phdPower = 3f;
    public float researcherPower = 10f;
    public float aiPower = 100f;

    public float beverageMulti = 0.02f;
    public float pcMulti = 0.05f;
    public float serverMulti = 0.2f;
    void Update()
    {
        CalculateTotalWorkforce();
        ApplyWorkforce(Time.deltaTime);
    }

    public void CalculateTotalWorkforce() {
        totalWorkForce = StaticResources.valueIntern * internPower + StaticResources.valueStudent * studentPower + StaticResources.valuePhDCandidate * phdPower + StaticResources.valueResearcher * researcherPower + StaticResources.valueResearchAI * aiPower;
        totalWorkForce = totalWorkForce * (1+(StaticResources.valueBeverage * beverageMulti));
        totalWorkForce = totalWorkForce * (1+(StaticResources.valuePC * pcMulti));
        totalWorkForce = totalWorkForce * (1+(StaticResources.valueServer * serverMulti));
    }

    public void ApplyWorkforce(float deltaTime) {
        StaticResources.valueUSD += totalWorkForce * StaticResources.percentUSD * deltaTime;
        StaticResources.valueReferences += totalWorkForce * StaticResources.percentReferences* deltaTime;
        StaticResources.valueReputation += totalWorkForce * StaticResources.percentReputation * deltaTime;
    }

}
