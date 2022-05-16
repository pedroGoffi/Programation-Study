using System;
using System.Text.Json;

namespace JSONReaderLecture
{
    public class Program
    {
        public static void Main()
        {
          var json = @"{""Nome"":""Carlos Silva"",""Idade"":33, ""Telefones"": { ""celular"": ""11-99999-9999"", ""comercial"": ""11-4444-4444""}}";
          var obj = JsonDocument.Parse(json);
          var nome = obj.RootElement.GetProperty("Nome").GetString();
          string Data_From_Form = Form.RootElement;

          Console.WriteLine("nome = {0}", nome);
        }
    }
}

// output:
//{"Date":"2019-08-01T00:00:00-07:00","TemperatureCelsius":25,"Summary":"Hot"}
