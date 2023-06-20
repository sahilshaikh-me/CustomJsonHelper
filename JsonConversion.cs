using UnityEngine;
using System.Collections.Generic;
using System.Text;

public class JsonConversion : MonoBehaviour
{
    [System.Serializable]
    public struct SerializableVector2
    {
        public float x;
        public float y;

        public SerializableVector2(Vector2 vector2)
        {
            x = vector2.x;
            y = vector2.y;
        }
    }

    [System.Serializable]
    public struct SerializableVector3
    {
        public float x;
        public float y;
        public float z;

        public SerializableVector3(Vector3 vector3)
        {
            x = vector3.x;
            y = vector3.y;
            z = vector3.z;
        }
    }

    [System.Serializable]
    public class SerializableGameObject
    {
        public string name;
        public SerializableVector3 position;
        public SerializableVector3 rotation;

        public SerializableGameObject(GameObject gameObject)
        {
            name = gameObject.name;
            position = new SerializableVector3(gameObject.transform.position);
            rotation = new SerializableVector3(gameObject.transform.rotation.eulerAngles);
        }
    }

    private void Start()
    {
        // Create an instance of SerializableVector2
        SerializableVector2 vector2Data = new SerializableVector2(new Vector2(1f, 2f));

        // Convert SerializableVector2 to JSON
        string vector2Json = JsonUtility.ToJson(vector2Data);

        Debug.Log(vector2Json);

        // Create an instance of SerializableVector3
        SerializableVector3 vector3Data = new SerializableVector3(new Vector3(3f, 4f, 5f));

        // Convert SerializableVector3 to JSON
        string vector3Json = JsonUtility.ToJson(vector3Data);

        Debug.Log(vector3Json);

        // Create an instance of SerializableGameObject
        SerializableGameObject gameObjectData = new SerializableGameObject(gameObject);

        // Convert SerializableGameObject to JSON
        string gameObjectJson = JsonUtility.ToJson(gameObjectData);

        Debug.Log(gameObjectJson);
    }
}
