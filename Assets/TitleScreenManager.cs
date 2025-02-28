using UnityEngine;

public class TitleScreenManager : MonoBehaviour
{
        public GameObject titleScreenPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        titleScreenPanel.SetActive(true);
        Time.timeScale = 0f;

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void StartGame()
    {
        titleScreenPanel.SetActive(false);
        Time.timeScale =1f;
        }
        
}

