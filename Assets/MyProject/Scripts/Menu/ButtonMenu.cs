using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public static class Loader 
{
    public static async UniTask SceneLoad(int index)
    {
        var nextScene = SceneManager.LoadSceneAsync(index);
        await nextScene.ToUniTask();
    }
}
