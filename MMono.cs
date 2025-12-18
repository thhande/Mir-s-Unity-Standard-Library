using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//auto loadcomponent before enter playtest
public abstract class MMono : MonoBehaviour
{
    protected virtual void LoadComponents()
    {

    }

    protected virtual void Reset()
    {
        LoadComponents();
    }

    protected virtual void OnValidate()
    {
#if UNITY_EDITOR
        LoadComponents();
#endif
    }



}
