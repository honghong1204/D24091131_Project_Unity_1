using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class GlobalVariable
{
    // Start is called before the first frame update
    public static int justGenerated = 0;
    public static List<Transform> Grounds;
    public static int GeneratedCount = 0;
    public static Vector3 curGeneratedLoc;
    public static int curScore = 0;
    public static List<Transform> GroundList0 = new List<Transform>();
    public static List<Transform> GroundList90 = new List<Transform>();
    public static float curDistanceFromEnemy = 0;
}
