using UnityEngine;

public class FactoryLoad
{
    public Object LoadObjects(Object objectPrefab, string namePrefab)
    {
        return objectPrefab = Resources.Load(namePrefab);
    }
}
