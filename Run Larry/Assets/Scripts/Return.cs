using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour 
{
    public void ReturnGamePlay()
    {
        SceneManager.LoadScene(0);
    }
}
