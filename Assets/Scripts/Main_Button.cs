using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Button : MonoBehaviour
{
    public void NaGa()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // ���ø����̼� ����
#endif
    }

    public void GameStart()
    {
        SceneManager.LoadScene("MainGameScene");
    }
}
