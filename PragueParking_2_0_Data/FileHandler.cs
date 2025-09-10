using System.Text.Json;
using System.Diagnostics;

namespace PragueParking_2_0_Data
{
    public class FileHandler
    {
        // Generisk metod för att spara data till JSON-fil
        public static void SaveDataToJson<T>(string filePath, T data)
        {
            try
            {
                var json = JsonSerializer.Serialize(data, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
                File.WriteAllText(filePath, json);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Fel vid JSON-skrivning: " + e.Message);
            }
        }
        // Generisk metod för att läsa data från JSON-fil
        public static T LoadDataFromJson<T>(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<T>(json);
                }
                else
                {
                    Debug.WriteLine($"File not found: {filePath}");
                    return default;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Fel vid JSON-läsning: " + e.Message);
                return default;
            }
        }
    }
}
