using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public void SceneLoad(int scene)
    {
        SceneManager.LoadScene(scene); 
    }
}
