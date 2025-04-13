using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Button : MonoBehaviour
{
    public void NaGa()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // 어플리케이션 종료
#endif
    }

    public void GameStart()
    {
        SceneManager.LoadScene("MainGameScene");
    }
}
