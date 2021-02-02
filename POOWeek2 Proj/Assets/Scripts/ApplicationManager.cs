using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    private static ApplicationManager _instance = null;

    public static ApplicationManager GetInstance()
    {
        if(null == _instance)
            _instance = new ApplicationManager();

        return _instance;
    }
}
