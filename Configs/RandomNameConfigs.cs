using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BanedTextConfig:ConfigBase
{
    private string name;

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
}



public partial class ConfigInfo
{
    Dictionary<string, RandomNameConfig> randomNameConfigs = new Dictionary<string, RandomNameConfig>();
    Dictionary<string, BanedTextConfig> banedDic = new Dictionary<string, BanedTextConfig>();

    public Dictionary<string, RandomNameConfig> RandomNameConfigs
    {
        get
        {
            return randomNameConfigs;
        }

        set
        {
            randomNameConfigs = value;
        }
    }

    public Dictionary<string, BanedTextConfig> BanedDic
    {
        get
        {
            return banedDic;
        }

        set
        {
            banedDic = value;
        }
    }
}

public class RandomNameConfig:ConfigBase
{
    private string fIRSTNAME;
    private string mIDDLENAME;
    private string lASTNAME;

    public string FIRSTNAME
    {
        get
        {
            return fIRSTNAME;
        }

        set
        {
            fIRSTNAME = value;
        }
    }

    public string MIDDLENAME
    {
        get
        {
            return mIDDLENAME;
        }

        set
        {
            mIDDLENAME = value;
        }
    }

    public string LASTNAME
    {
        get
        {
            return lASTNAME;
        }

        set
        {
            lASTNAME = value;
        }
    }
}


