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
            /// TinyMapper is double sided you config the mapper once and you can go from target 
            /// to source or the inverse as you want inlike AutoMapper where you have to create a 2 confics T=>S and S=>T 

            TinyMapper.Bind<TWriter, SWriter>();
        }

        /**
         *  resolve complex O(n+1)
         */ 
        public static void ComplexResolveModels()
        {
            /// even complex binding is clean and easy to anderstand 
            /// you can go to O(n+m) where m i dont know it but i guss it's a huge number or tiny like tinymapper ^^

            TinyMapper.Bind<TWriter, SWriter>(Config =>
            {
                Config.Bind(target => target.TBooks, source => source.SBooks);
            }
            );
        } 
    }
}
