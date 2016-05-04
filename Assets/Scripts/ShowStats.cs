using UnityEngine;
using System.Collections;

public class ShowStats : MonoBehaviour 
{
    void OnEnable()
    {
        NimosStats.stats.UpdateStats();
    }
}
