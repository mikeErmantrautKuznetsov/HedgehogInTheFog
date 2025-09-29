using UnityEngine;

public class FactoryInstantiate : MonoBehaviour
{
    public GameObject InstantiatePrefab(GameObject prefabInstate, Vector3 position)
    {
        GameObject gameObject = Instantiate(prefabInstate, position, Quaternion.identity, null);
        return gameObject;
    }
}
