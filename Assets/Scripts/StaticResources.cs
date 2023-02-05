using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticResources
{

    public static List<float> staticCosts = new List<float> {5, 80, 300, 1500, 10000, 50, 800, 4000};

    public static List<int> staticSigmoid = new List<int> {200, 800, 4000, 20000};

    public static List<float> staticPaper = new List<float>{0.1f, 0.5f, 3f, 20f};

    //Resources
    public static float valueUSD;
    public static float valueReferences;
    public static float valueReputation;
    public static float valuePublishedPapers;

    //AreaStatus

    public static int areaStatus;

    //AutomationUnits

    public static int valueIntern;
    public static int valueStudent;
    public static int valuePhDCandidate;
    public static int valueResearcher;
    public static int valueResearchAI;

    //AutomationAllocation
    public static float percentUSD;
    public static float percentReferences;
    public static float percentReputation;

    //Boosts

    public static int valueBeverage;
    public static int valuePC;
    public static int valueServer;

    //Publishing

    public static int publishingType;
    public static int allocateResources;

    public static float calculateUSD() {
        return 0;
    }

}
