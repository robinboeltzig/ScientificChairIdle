using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoResourceHandler : MonoBehaviour
{
    public float totalWorkForce;

    public float internPower = 0.3f;
    public float studentPower = 2.5f;
    public float phdPower = 10f;
    public float researcherPower = 35f;
    public float aiPower = 500f;

    public float beverageMulti = 0.03f;
    public float pcMulti = 0.08f;
    public float serverMulti = 0.3f;
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
        StaticResources.valueUSD += totalWorkForce * StaticResources.percentUSD * deltaTime /100;
        StaticResources.valueReferences += totalWorkForce * StaticResources.percentReferences* deltaTime /100;
        StaticResources.valueReputation += totalWorkForce * StaticResources.percentReputation * deltaTime /100;
    }

}
