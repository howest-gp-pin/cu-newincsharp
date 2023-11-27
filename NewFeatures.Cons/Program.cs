using NewFeatures.Domain;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NewFeatures.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName = "Alice";

            //not possible, neither is escaping the " characters, ...
            //string json = $"{"name": "{inputname}"}";

            string json = $$"""
                {"name": "{{inputName}}" }
                """;

            Console.WriteLine("Raw Json: " + json);

            Student student = JsonSerializer.Deserialize<Student>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            Console.WriteLine("Deserialized: " + student.Name);



        }
    }
}
