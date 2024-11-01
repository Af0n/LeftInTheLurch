using Unity.VisualScripting;
using UnityEngine;

public class Associate : MonoBehaviour
{
    public string title;

    public bool debug;

    [Range(-10,10)]
    [Tooltip("DEBUGGING")]
    public float standing;

    public float Affinity{
        get{ return Mathf.RoundToInt(standing); }
    }

    public void ChangeStanding(float delta){
        if(debug){
            Debug.Log($"adding {delta} to standing ({standing}): {standing + delta}");
        }

        standing += delta;
    }

    public void SetStanding(float value){
        if(debug){
            Debug.Log($"setting standing to {value}");
        }

        standing = value;
    }

    public void Log(){
        if(debug){
            Debug.Log($"{title}\nAffinity of {Affinity}\nStanding of {standing}");
            return;
        }
        Debug.Log($"{title}\nAffinity of {Affinity}");
    }
}
