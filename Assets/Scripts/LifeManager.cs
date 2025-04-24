using UnityEngine;
using TMPro;

public class LifeManager : MonoBehaviour
{

    public static LifeManager instance; //static = global value()
    public int totalLife = 3;
    public TMP_Text lifeText;

    public GameObject uiPanel; //restart UI

    private void Awake() // before void start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateLifeUI();
        HideUI();
    }

    public void MinusLife(int amount)
    {
        totalLife -= amount;
        UpdateLifeUI();
        if (totalLife <= 0) //restart UI
        {
            totalLife = 0;
            ShowUI();
        }
    }

    void UpdateLifeUI()
    {
        if (lifeText != null)
        {
            lifeText.text = "Life: " + totalLife;
        }
    }

    

    // Restart UI
    public void ShowUI()
    {
        uiPanel.SetActive(true);
    }
    public void HideUI()
    {
        uiPanel.SetActive(false);
    }
    public void ToggleUI()
    {
        uiPanel.SetActive(!uiPanel.activeSelf);
    }

}