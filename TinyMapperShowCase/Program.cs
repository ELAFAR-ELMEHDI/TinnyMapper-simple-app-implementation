using Nelibur.ObjectMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyMapperShowCase.Models;

namespace TinyMapperShowCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /// reslove models
            MapperConfig.SimpleResolveModels();

            /// simple version
            var targetWriter = new TWriter
            {
                ID = 1,
                FirstName = "EL MEHDI",
                LastName = "EL AFAR",
                Pays = "MAROC",
                Age = 25
            };
            var sourceWriter = TinyMapper.Map<SWriter>(targetWriter);
            sourceWriter.FirstName = "OUMAYMA";
            sourceWriter.LastName = "OUMAYMA";
            sourceWriter.Age = 22;
            var NewTargetWriter = TinyMapper.Map<TWriter>(sourceWriter);

            /// complex version
            
        }
    }
}
