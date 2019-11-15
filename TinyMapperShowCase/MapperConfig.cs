using Nelibur.ObjectMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyMapperShowCase.Models;

namespace TinyMapperShowCase
{
    public static class MapperConfig
    {
        /**
         * resolve simple O(n)
         */ 
        public static void SimpleResolveModels()
        {
            TinyMapper.Bind<TWriter, SWriter>();
        }

        /**
         *  resolve complex O(n+1)
         */ 
        public static void ComplexResolveModels()
        {
            TinyMapper.Bind<TWriter, SWriter>(Config =>
            {
                Config.Bind(target => target.TBooks, source => source.SBooks);
            }
            );
        } 
    }
}
