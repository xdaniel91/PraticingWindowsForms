using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WindowsFormsLibrary
{
    public class Person
    {
        public class Unit
        {
            [Required(ErrorMessage = "Campo nome obrigatório!")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Campo Data de nascimento obrigatório!")]
            public DateTime Birth { get; set; }

            [Required(ErrorMessage = "Campo CPF obrigatório!")]
            [StringLength(11), MinLength(11)]
            public string CPF { get; set; }

            [Required(ErrorMessage = "Campo e-mail obrigatório!")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Campo ID obrigatório!")]

            [StringLength(4), MinLength(4)]
            public string Id { get; set; }

        }

        public static Unit DesSerializerUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        public static string SerializerUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }

    }
}

