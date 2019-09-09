using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public partial  class ConfigInfo
{
    Dictionary<string, RoleConfig> roleConfigs = new Dictionary<string, RoleConfig>();

    public Dictionary<string, RoleConfig> RoleConfigs
    {
        get
        {
            return roleConfigs;
        }

        set
        {
            roleConfigs = value;
        }
    }
}

public class RoleConfig:ConfigBase
{
    private string name;
    private string describe;
    private string model;
    private string picture;
    private string roleClass;
    private string job;

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

    public string Describe
    {
        get
        {
            return describe;
        }

        set
        {
            describe = value;
        }
    }

    public string Model
    {
        get
        {
            return model;
        }

        set
        {
            model = value;
        }
    }

    public string Picture
    {
        get
        {
            return picture;
        }

        set
        {
            picture = value;
        }
    }

    public string RoleClass
    {
        get
        {
            return roleClass;
        }

        set
        {
            roleClass = value;
        }
    }

    public string Job
    {
        get
        {
            return job;
        }

        set
        {
            job = value;
        }
    }
}
