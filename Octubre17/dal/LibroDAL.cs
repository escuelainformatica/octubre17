using Octubre17.midb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Octubre17.dal
{
    public class LibroDAL
    {
        public static List<Libro> Listar()
        {
            var r=new List<Libro>();
            using(var grupo=new Model1())
            {
                r=grupo.Libro.ToList();
            }
            return r;
        }
    }
}