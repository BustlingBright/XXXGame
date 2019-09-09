using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public partial class ConfigInfo
{
    Dictionary<string, ThingConfig> thingConfigs = new Dictionary<string, ThingConfig>();

    public Dictionary<string, ThingConfig> ThingConfigs
    {
        get
        {
            return thingConfigs;
        }

        set
        {
            thingConfigs = value;
        }
    }
}


public class ThingConfig : ConfigBase {
    private string name;
    private string attack;
    private string hpAdd;
    private string mpAdd;
    private string agile;
    private string level;
    private string price;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public string Attack
    {
        get
        {
            return attack;
        }

        set
        {
            attack = value;
        }
    }

    public string HpAdd
    {
        get
        {
            return hpAdd;
        }

        set
        {
            hpAdd = value;
        }
    }

    public string MpAdd
    {
        get
        {
            return mpAdd;
        }

        set
        {
            mpAdd = value;
        }
    }

    public string Agile
    {
        get
        {
            return agile;
        }

        set
        {
            agile = value;
        }
    }

    public string Level
    {
        get
        {
            return level;
        }

        set
        {
            level = value;
        }
    }

    public string Price
    {
        get
        {
            return price;
        }

        set
        {
            price = value;
        }
    }
}
