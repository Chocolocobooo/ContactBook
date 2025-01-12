using ContactBook.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ContactBook.Services
{
    public class FileService
    {
        private readonly string _directoryPath;
        private readonly string _filePath;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public FileService(string directoryPath = "Data", string fileName = "list.json")
        {
            _directoryPath = directoryPath;
            _filePath = Path.Combine(_directoryPath, fileName);
        }

        public void SaveToFile(List<Contact> list)
        {
            try
            {
                if (!Directory.Exists(_directoryPath))
                    Directory.CreateDirectory(_directoryPath);

                var json = JsonSerializer.Serialize(list, _jsonSerializerOptions);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public List<Contact> LoadListFromFile()
        {
            try
            {
                if (!File.Exists(_filePath))
                    return [];

                var json = File.ReadAllText(_filePath);
                var list = JsonSerializer.Deserialize<List<Contact>>(json, _jsonSerializerOptions);
                return list ?? [];
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return [];
            }
        }
    }
}
