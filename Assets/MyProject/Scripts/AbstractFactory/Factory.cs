using UnityEngine;

public class Factory : AbstractionFactory
{
    private Transform _pointSpawn;
    private FactoryInstantiate _factoryInstantiate = new FactoryInstantiate();
    private FactoryLoad _factoryLoad = new FactoryLoad();

    private const string _playerPrefab = "Prefabs/Player";

    private GameObject _playerGameObject;

    public Factory(Transform pointSpawn)
    {
        _pointSpawn = pointSpawn;
    }

    public override GameObject CreateGameObjects(Vector3 position)
    {
        var playerObject = _factoryInstantiate.InstantiatePrefab((GameObject)_factoryLoad.LoadObjects(_playerGameObject, _playerPrefab), _pointSpawn.position);
        return playerObject;
    }
}
