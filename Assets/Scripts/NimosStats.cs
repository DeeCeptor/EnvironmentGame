using UnityEngine;
using System.Collections;

public class NimosStats : MonoBehaviour 
{
    public static NimosStats stats;

    public int Resolve = 4;
    public int Charm = 2;
    public int Intellect = 3;

    public float Money = 0;

    // 0 = Hate, 1 = Dislike, 2 = Neutral, 3 = Like, 4 = Love
    public int Soilsmith_Relationship = 3;
    public int Jamminben_Relationship = 2;
    public int Pinkerton_Relationship = 0;


    public string GetStringRelationship(int number)
    {
        switch (number)
        {
            case 0:
                return "Hate";
            case 1:
                return "Dislike";
            case 2:
                return "Neutral";
            case 3:
                return "Like";
            case 4:
                return "Love";
            default:
                return "No setting";
        }
    }

    void Awake()
    {
        stats = this;
        DontDestroyOnLoad(this.gameObject);
    }
    void Start () 
	{
	
	}
	

	void Update () 
	{
	
	}
}
