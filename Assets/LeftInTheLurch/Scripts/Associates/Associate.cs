using UnityEngine;

public class Associate : MonoBehaviour
{
    public string title;

    public bool debug;

    [Range(0,100)]
    [Tooltip("DEBUGGING")]
    private int standing;

    public float Affinity{
        get{
            return standing / 20;
        }
    }
    
    public string LogMessage{
        get{
            if(debug){
                return $"{title}\nAffinity of {Affinity}\nStanding of {standing}";
            }
            return $"{title}\nAffinity of {Affinity}";
        }
    }

    public void ChangeStanding(int delta){
        if(debug){
            Debug.Log($"adding {delta} to standing ({standing}): {standing + delta}");
        }

        standing += delta;

        ClampStanding();
    }

    public void SetStanding(int value){
        if(debug){
            Debug.Log($"setting standing to {value}");
        }

        standing = value;

        ClampStanding();
    }

    public int GetStanding(){
        return standing;
    }

    private void ClampStanding(){
        standing = Mathf.Clamp(standing, 0, 100);
    }

    public void Log(){
        Debug.Log(LogMessage);
    }

    public void ToggleDebug(){
        debug = !debug;
    }
}
