using UnityEngine;

namespace ATCNK.SaveSystem
{
    public static class SaveHelper
    {
        #region Constants

        private const string QuaternionW = "_QW";
        private const string QuaternionX = "_QX";
        private const string QuaternionY = "_QY";
        private const string QuaternionZ = "_QZ";

        private const string Vector2X = "_V2X";
        private const string Vector2Y = "_V2Y";

        private const string Vector3X = "_V3X";
        private const string Vector3Y = "_V3Y";
        private const string Vector3Z = "_V3Z";

        private const string Vector4W = "_V4W";
        private const string Vector4X = "_V4X";
        private const string Vector4Y = "_V4Y";
        private const string Vector4Z = "_V4Z";

        #endregion

        #region SaveMethods

        public static void Save(string key, bool value)
        {
            PlayerPrefs.SetInt(key, value ? 1 : 0);
        }

        public static void Save(string key, char value)
        {
            PlayerPrefs.SetString(key, value.ToString());
        }

        public static void Save(string key, float value)
        {
            PlayerPrefs.SetFloat(key, value);
        }

        public static void Save(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }

        public static void Save(string key, Quaternion value)
        {
            PlayerPrefs.SetFloat(key, 0f);
            PlayerPrefs.SetFloat(key + QuaternionW, value.w);
            PlayerPrefs.SetFloat(key + QuaternionX, value.x);
            PlayerPrefs.SetFloat(key + QuaternionY, value.y);
            PlayerPrefs.SetFloat(key + QuaternionZ, value.z);
        }

        public static void Save(string key, Vector2 value)
        {
            PlayerPrefs.SetFloat(key, 0f);
            PlayerPrefs.SetFloat(key + Vector2X, value.x);
            PlayerPrefs.SetFloat(key + Vector2Y, value.y);
        }

        public static void Save(string key, Vector3 value)
        {
            PlayerPrefs.SetFloat(key, 0f);
            PlayerPrefs.SetFloat(key + Vector3X, value.x);
            PlayerPrefs.SetFloat(key + Vector3Y, value.y);
            PlayerPrefs.SetFloat(key + Vector3Z, value.z);
        }

        public static void Save(string key, Vector4 value)
        {
            PlayerPrefs.SetFloat(key, 0f);
            PlayerPrefs.SetFloat(key + Vector4X, value.x);
            PlayerPrefs.SetFloat(key + Vector4Y, value.y);
            PlayerPrefs.SetFloat(key + Vector4Z, value.z);
            PlayerPrefs.SetFloat(key + Vector4W, value.w);
        }

        #endregion

        #region LoadMethods

        public static bool LoadBool(string key)
        {
            return PlayerPrefs.GetInt(key) != 0;
        }

        public static char LoadChar(string key)
        {
            return PlayerPrefs.GetString(key)[0];
        }

        public static float LoadFloat(string key)
        {
            return PlayerPrefs.GetFloat(key);
        }

        public static int LoadInt(string key)
        {
            return PlayerPrefs.GetInt(key);
        }

        public static Quaternion LoadQuaternion(string key)
        {
            return new Quaternion(PlayerPrefs.GetFloat(key + QuaternionX), PlayerPrefs.GetFloat(key + QuaternionY), PlayerPrefs.GetFloat(key + QuaternionZ), PlayerPrefs.GetFloat(key + QuaternionW));
        }

        public static Vector2 LoadVector2(string key)
        {
            return new Vector2(PlayerPrefs.GetFloat(key + Vector2X), PlayerPrefs.GetFloat(key + Vector2Y));
        }

        public static Vector3 LoadVector3(string key)
        {
            return new Vector3(PlayerPrefs.GetFloat(key + Vector3X), PlayerPrefs.GetFloat(key + Vector3Y), PlayerPrefs.GetFloat(key + Vector3Z));
        }

        public static Vector4 LoadVector4(string key)
        {
            return new Vector4(PlayerPrefs.GetFloat(key + Vector4X), PlayerPrefs.GetFloat(key + Vector4Y), PlayerPrefs.GetFloat(key + Vector4Z), PlayerPrefs.GetFloat(key + Vector4W));
        }

        #endregion

        #region DeleteMethods

        public static void Delete(string key)
        {
            PlayerPrefs.DeleteKey(key);
        }

        public static void DeleteAll()
        {
            PlayerPrefs.DeleteAll();
        }

        #endregion

        #region KeyCheckMethods

        public static bool HasKey(string key)
        {
            return PlayerPrefs.HasKey(key);
        }

        #endregion
    }
}