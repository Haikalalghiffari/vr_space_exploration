using UnityEngine;

public class Spawn : MonoBehaviour
{
    [Header("Panel Deskripsi")]
    public GameObject descriptionPanel;

    [Header("Object Spawn")]
    public GameObject gravityCube;

    void Start()
    {
        if (descriptionPanel != null)
            descriptionPanel.SetActive(false);

        if (gravityCube != null)
            gravityCube.SetActive(false);
    }

    public void ToggleDescription()
    {
        if (descriptionPanel != null)
            descriptionPanel.SetActive(!descriptionPanel.activeSelf);
    }

    public void SpawnCube()
    {
        if (gravityCube != null)
        {
            gravityCube.SetActive(true);

            Rigidbody rb = gravityCube.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }

    public void HideCube()
    {
        if (gravityCube != null)
            gravityCube.SetActive(false);
    }
}