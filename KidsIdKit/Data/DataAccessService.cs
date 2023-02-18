﻿using Microsoft.AspNetCore.Components.Forms;
using System.Text.Json;

namespace KidsIdKit.Data
{
  public class DataAccessService : IDataAccess
  {
    private string fileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
      + Path.DirectorySeparatorChar + "kidsidkitdata.txt";

    public Family GetData()
    {
      try
      {
        if (File.Exists(fileName))
        {
          var json = File.ReadAllText(fileName);
          // TODO: add decryption
          return JsonSerializer.Deserialize<Family>(json);
        }
        else
        {
          return new Family();
        }
      }
      catch
      {
        return new Family();
      }
    }

    public void SaveData(Family data)
    {
      if (File.Exists(fileName))
        File.Copy(fileName, fileName + ".bak");
      var json = JsonSerializer.Serialize(data);
      // TODO: add encryption
      File.WriteAllText(fileName, json);
    }
  }
}
