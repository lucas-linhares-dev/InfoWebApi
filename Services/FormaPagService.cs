using InfoWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace InfoWeb.Services
{
    public static class FormaPagService
    {
        static List<FormaPag> FormasPag { get; } = new List<FormaPag>();

        public static List<FormaPag> GetAll() => FormasPag;

        public static FormaPag? Get(int id) => FormasPag.FirstOrDefault(p => p.fpg_codigo == id);

        public static void Add(FormaPag formaPag)
        {
            FormasPag.Add(formaPag);
        }

        public static void Delete(int id)
        {
            var FormaPag = Get(id);
            if (FormaPag is null)
                return;

            FormasPag.Remove(FormaPag);
        }

        public static void Update(FormaPag formaPag)
        {
            var index = FormasPag.FindIndex(p => p.fpg_codigo == formaPag.fpg_codigo);
            if (index == -1)
                return;

            FormasPag[index] = formaPag;
        }
    }
}