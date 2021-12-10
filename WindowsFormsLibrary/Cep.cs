using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft;

namespace System
{
    public static class Cep
    {

        public class CepUnit
        {
            public string CEP { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string UF { get; set; }
        }

        //Deserializer, transforma json em classe
        public static CepUnit JsonParaClass(string json)
        {
            return JsonConvert.DeserializeObject<CepUnit>(json);
        }

        //Serializer, transforma classe em json
        public static string ClassParaJson(CepUnit cep)
        {
            return JsonConvert.SerializeObject(cep);
        }
    }
}
