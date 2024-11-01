using Unity.VisualScripting;
using UnityEngine;

public class Associate : MonoBehaviour
{
    [Range(-10,10)]
    [Tooltip("DEBUGGING")]
    private float standing;

    public float Affinity{
        get{ return Mathf.RoundToInt(standing); }
    }

    public void ChangeStanding(float delta){
        standing += delta;
    }

    public void SetStanding(float value){
        standing = value;
    }
}
