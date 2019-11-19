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
            /// simple reslove models
            
            MapperConfig.SimpleResolveModels();

            /// simple version
            
            // prepare test data
            var targetWriter = new TWriter
            {
                ID = 1,
                FirstName = "EL MEHDI",
                LastName = "EL AFAR",
                Pays = "MAROC",
                Age = 25
            };

            /// mapping t => s

            var sourceWriter = TinyMapper.Map<SWriter>(targetWriter);
            sourceWriter.FirstName = "CHARAF";
            sourceWriter.LastName = "KHAMLICHI";

            /// mapping s => t -- onr config for the 2, nice clean and cool.

            var NewTargetWriter = TinyMapper.Map<TWriter>(sourceWriter);


            /// complex resolve models
            
            MapperConfig.ComplexResolveModels();

            /// complex version
            targetWriter.TBooks = new List<TBook>();
            targetWriter.TBooks.Add(new TBook {
                    ID = 1,
                    WriterID = 1,
                    Title = "c#?",
                    PublishDate = DateTime.Now
            });

            /// mapping C : t => s

            var complexSourceWriter = TinyMapper.Map<SWriter>(targetWriter);
            complexSourceWriter.FirstName = "CHARAF";
            complexSourceWriter.LastName = "KHAMLICHI";

            /// mapping C : s => t

            var NewCmmplexTargetWriter = TinyMapper.Map<TWriter>(sourceWriter);
        }
    }
}
