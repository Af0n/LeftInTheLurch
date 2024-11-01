using UnityEngine;

public class Associate : MonoBehaviour
{
    public string title;

    public bool debug;

    [Range(-10,10)]
    [Tooltip("DEBUGGING")]
    private float standing;

    public float Affinity{
        get{ return Mathf.RoundToInt(standing); }
    }
    
    public string LogMessage{
        get{
            if(debug){
                return $"{title}\nAffinity of {Affinity}\nStanding of {standing}";
            }
            return $"{title}\nAffinity of {Affinity}";
        }
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
        Debug.Log(LogMessage);
    }

    public void ToggleDebug(){
        debug = !debug;
    }
}
