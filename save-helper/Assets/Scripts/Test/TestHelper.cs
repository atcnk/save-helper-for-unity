using UnityEngine;
using ATCNK.SaveSystem;

public class TestHelper : MonoBehaviour
{
    [SerializeField] private bool _bool;
    [SerializeField] private char _char;
    [SerializeField] private float _float;
    [SerializeField] private int _int;
    [SerializeField] private Vector2 _vector2;
    [SerializeField] private Vector3 _vector3;
    [SerializeField] private Vector4 _vector4;
    [SerializeField] private Quaternion _quaternion;

    private void Start()
    {
        Debug.Log("Press X to save values on TestHelper object.");
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SaveHelper.Save("BoolKey", _bool);
            SaveHelper.Save("CharKey", _char);
            SaveHelper.Save("FloatKey", _float);
            SaveHelper.Save("IntKey", _int);
            SaveHelper.Save("Vector2Key", _vector2);
            SaveHelper.Save("Vector3Key", _vector3);
            SaveHelper.Save("Vector4Key", _vector4);
            SaveHelper.Save("QuaternionKey", _quaternion);
            
            Debug.Log("All values are saved.");
            Debug.Log("You can change values on inspector to test save system.");
            Debug.Log("Press 'Z' to load saved values.");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            _bool = SaveHelper.LoadBool("BoolKey");
            _char = SaveHelper.LoadChar("CharKey");
            _float = SaveHelper.LoadFloat("FloatKey");
            _int = SaveHelper.LoadInt("IntKey");
            _vector2 = SaveHelper.LoadVector2("Vector2Key");
            _vector3 = SaveHelper.LoadVector3("Vector3Key");
            _vector4 = SaveHelper.LoadVector4("Vector4Key");
            _quaternion = SaveHelper.LoadQuaternion("QuaternionKey");
            
            Debug.Log("All values are loaded from save.");
        }
    }
}
