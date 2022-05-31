using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class savesystem
{
    public static void SavePlayer(PlayerMovementScript p){
        BinaryFormatter f = new BinaryFormatter();
        string path = Application.persistentDataPath+"/player.dss";
        FileStream s = new FileStream(path,FileMode.Create);
        playerdata p1 = new playerdata(p);

        f.Serialize(s,p1);
        s.Close();

    }
    public static playerdata LoadPlayer(){
        string path = Application.persistentDataPath+"/player.dss";
        BinaryFormatter f = new BinaryFormatter();
        FileStream s = new FileStream(path,FileMode.Open);
        playerdata position = f.Deserialize(s) as playerdata;
        s.Close();
        return position;
        }
}
