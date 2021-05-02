using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveSusana(SusanaControlled susana)
    {
        BinaryFormatter fomatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/susana.ytano";

        FileStream stream = new FileStream(path, FileMode.Create);

        SusanaData data = new SusanaData(susana);
        
        //Writing data to the file
        fomatter.Serialize(stream, data);
        stream.Close();
    }

    public static SusanaData LoadSusana ()
    {
        string path = Application.persistentDataPath + "/susana.ytano";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SusanaData data = formatter.Deserialize(stream) as SusanaData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Susana Data not found in " + path);
            return null;
        }
    }
}
