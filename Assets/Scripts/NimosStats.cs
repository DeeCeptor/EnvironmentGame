using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

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

    public List<string> stat_improvements = new List<string>(); // So we don't add more and more stats

    public Dictionary<string, GameObject> items_ideas = new Dictionary<string, GameObject>();
    public GameObject ecology_poster;
    public GameObject landfills;
    public GameObject bags;
    public GameObject bucket;
    public GameObject recycling_saves;

    public int dialogues_printing = 0;
    public bool Can_Start_Printing()
    {
        return true;
        /*
        if (dialogues_printing < 1)
        {
            dialogues_printing++;
            return true;
        }
        else
            return false;*/
    }

    public bool HasItemIdea(string name)
    {
        return items_ideas[name].activeSelf;
    }
    public void AcquireIdeaItem(string name)
    {
        items_ideas[name].SetActive(true);
    }

    public void AddStats(string source, string message, string idea_item, int Intelli, int Char, int Resolv, float Mons, int JB, int Pinkerton, int Soilsmith)
    {
        if (stat_improvements.Contains(source))
            return;

        stat_improvements.Add(source);
        Intellect += Intelli;
        Charm += Char;
        Resolve += Resolv;
        Money += Mons;

        Soilsmith_Relationship += Soilsmith;
        Pinkerton_Relationship += Pinkerton;
        Jamminben_Relationship += JB;

        if (idea_item != "")
            AcquireIdeaItem(idea_item);

        GameObject obj = (GameObject)Instantiate(Resources.Load<GameObject>("GainedStat!"));
        obj.transform.SetParent(UIManager.ui_manager.canvas.transform);
        obj.transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        obj.GetComponentInChildren<Text>().text = message;

        UpdateStats();
    }
    public void UpdateStats()
    {
        UIManager.ui_manager.Resolve.text = "Resolve: " + NimosStats.stats.Resolve;
        UIManager.ui_manager.Charm.text = "Charm: " + NimosStats.stats.Charm;
        UIManager.ui_manager.Intellect.text = "Intellect: " + NimosStats.stats.Intellect;
        UIManager.ui_manager.Money.text = "Money: " + NimosStats.stats.Money + "$";
    }

    public string RelationshipWith(string name)
    {
        switch (name)
        {
            case "Jammin' Ben":
                return GetStringRelationship(Jamminben_Relationship);
            case "Mrs. Pinkerton":
                return GetStringRelationship(Pinkerton_Relationship);
            case "Mr. Soilsmith":
                return GetStringRelationship(Soilsmith_Relationship);
            case "Nimo":
                return "";
        }
        return "";
    }
    public string GetStringRelationship(int number)
    {
        switch (number)
        {
            case -2:
                return "Hates me :'(";
            case -1:
                return "Hates me :(";
            case 0:
                return "Hates me";
            case 1:
                return "Dislikes me";
            case 2:
                return "Neutral";
            case 3:
                return "Friend";
            case 4:
                return "Super friends!";
            case 5:
                return "Super friends!!";
            case 6:
                return "Super friends!!!";
            default:
                return "No setting";
        }
    }

    void Awake()
    {
        stats = this;
        DontDestroyOnLoad(this.gameObject);

        items_ideas.Add("Ecology Club Poster", ecology_poster);
        items_ideas.Add("Landfills Harm Animals", landfills);
        items_ideas.Add("Re-Usable Bags", bags);
        items_ideas.Add("Drop in the Bucket", bucket);
        items_ideas.Add("Recycling Saves Money", recycling_saves);
    }
    void Start () 
	{
	
	}
	

	void Update () 
	{
	
	}
}
