//In many situations, child components will have to interact with others, these components will interact with others through a core, which is connected to every child components

using UnityEngine;

public abstract class CoreBase : MMono
{
    protected T LoadComponent<T>(ref T field, bool searchInChildren = false)
        where T : Component
    {
        if (field == null)
        {
            field = searchInChildren ?
                GetComponentInChildren<T>(true) :
                GetComponent<T>();
        }

        return field;
    }
}
