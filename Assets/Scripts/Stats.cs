using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{

    private TextMeshProUGUI statsLabel;

    public int ProjectilesFired { get; private set; }

    public int PolaroidsTook { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        statsLabel = GetComponent<TextMeshProUGUI>();
        UpdateUI();
    }

    private void UpdateUI()
    {
        statsLabel.text = $"Stats\nProjectiles Fired: {ProjectilesFired}\nPolaroids Took: {PolaroidsTook}\n\nPress 'Reset' or secondary button to wipe the stats and restart the scene.";
    }

    public void ProjectileFired()
    {
        ProjectilesFired++;
        UpdateUI();
    }

    public void PolaroidTaken()
    {
        PolaroidsTook++;
        UpdateUI();
    }


}
