using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    private int _totalClaws;
    private int _clawsCollected;

    public TextMeshProUGUI clawCount;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _totalClaws = FindObjectsOfType<Collectable>().Length;
        DisplayClawCount();
    }

    void DisplayClawCount()
    {
        clawCount.SetText(_clawsCollected + " / " + _totalClaws);
    }

    public void HandleCollected()
    {
        _clawsCollected++;
        DisplayClawCount();
        if(_clawsCollected == _totalClaws)
        {
            YouWinMenu.Instance.Show();
            SoundManager.Instance.PlayClawsCollected();
        }

        SoundManager.Instance.PlayClawCollect();
    }
}